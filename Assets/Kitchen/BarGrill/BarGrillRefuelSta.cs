using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarGrillRefuelSta : BarGrillAbs
{
 
     [Header("🔥 Timer Settings")]
    [SerializeField] private float maxTime = 100f;   // thời gian cháy tối đa khi đầy
    [SerializeField] private float countdown;       // thời gian còn lại
    protected override void Start()
    {
        countdown = 100f;
        this.BarGrillCtrl.BarGrillState.ChangeState(StateOfKitchen.Ideal);
    }

    protected virtual void FixedUpdate()
    {
        if (this.BarGrillCtrl.BarGrillState.currentState == StateOfKitchen.Cold) return;

        countdown -= Time.deltaTime;
        countdown = Mathf.Max(countdown, 0f);
        this.SwitchState();
    }

    protected virtual void SwitchState()
    {
        StateOfKitchen newState = countdown switch
        {
            <= 0f => StateOfKitchen.Cold,
            <= 20f => StateOfKitchen.Low,
            <= 80f => StateOfKitchen.Ideal,
            _ => StateOfKitchen.High
        };

        this.BarGrillCtrl.BarGrillState.ChangeState(newState);
    
    
    }



    public void AddCharcoal(float FuelAddTime)
    {
        float addedTime = FuelAddTime;
        countdown += addedTime;

        if (countdown > maxTime)
            countdown = maxTime;

    }

}
