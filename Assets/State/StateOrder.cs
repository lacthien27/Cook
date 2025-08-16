using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class StateOrder : StateAbs
{
    [SerializeField] public float timer = 0;

    public static Action OnComplete_Order; // event thông báo cho MinoCtrl

    protected override void OnUpdate()
    {

        this.ExecuteLogic();
    }
    protected virtual void ExecuteLogic()
    {
        this.timer += Time.deltaTime;
        if (timer < 1f) return;

        timer = 0;
      //  Debug.LogWarning("StateOrder: ExecuteLogic", gameObject);
     //  this.stateMachineCtrl.ChangeState(this.stateMachineCtrl.StateWait);

       // OnComplete_Order?.Invoke();  
    }


}