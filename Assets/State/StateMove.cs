using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StateMove : StateAbs
{
     [SerializeField] public float timer = 0;

     public static Action OnComplete_Moved;

     protected override void OnUpdate()
    {

        this.ExecuteLogic();
    }
    protected virtual void ExecuteLogic()
    {
        this.timer += Time.deltaTime;
        if (timer > 1f)
        {
            this.stateMachineCtrl.ChangeState(this.stateMachineCtrl.StateOrder);
            OnComplete_Moved?.Invoke();
        }
       
    }
}
