using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class StateOrder : StateAbs
{
    [SerializeField] public float timer = 0;

    public static Action OnStart_Order; // event thông báo cho MinoCtrl

    protected override void OnUpdate()
    {

        this.ExecuteLogic();
    }
    protected virtual void ExecuteLogic()
    {
        this.timer += Time.deltaTime;
        if (timer < 0.1f) return;

        timer = 0;
        OnStart_Order?.Invoke();
        this.stateMachineCtrl.ChangeState(this.stateMachineCtrl.StateWait);

    }

    
    
   


}