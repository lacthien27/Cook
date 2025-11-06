using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenRefuelSta : KitchenAbs
{
    [Header("🔥 Timer Settings")]
    [SerializeField] private float maxTime = 100f;   // thời gian cháy tối đa khi đầy
    [SerializeField] private float countdown;       // thời gian còn lại

   // [Header("🪵 Charcoal Settings")]
    //[SerializeField] private float charcoalAddTime = 20f; // +2s mỗi charcoal


   // public StateOfKitchen currentState = StateOfKitchen.Cold;   // mặc định ban đầu là sống

    protected override void Start()
    {
        countdown = 100f;
        this.KitchenCtrl.KitchenState.ChangeState(StateOfKitchen.Ideal);
    }

    protected virtual void FixedUpdate()
    {
        if (this.kitchenCtrl.KitchenState.currentState == StateOfKitchen.Cold) return;

        countdown -= Time.deltaTime;
        countdown = Mathf.Max(countdown, 0f);
        this.SwitchState();

        // 🧠 Xác định trạng thái mới bằng switch expression
      /**  StateOfKitchen newState = countdown switch
        {
            <= 0f => StateOfKitchen.Cold,
            <= 20f => StateOfKitchen.Low,
            <= 80f => StateOfKitchen.Ideal,
            _ => StateOfKitchen.High
        };

        this.KitchenCtrl.KitchenState.ChangeState(newState);**/
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

        this.KitchenCtrl.KitchenState.ChangeState(newState);
    }



    public void AddCharcoal(float FuelAddTime)
    {
        float addedTime = FuelAddTime;
        countdown += addedTime;

        if (countdown > maxTime)
            countdown = maxTime;

    }


    
}
