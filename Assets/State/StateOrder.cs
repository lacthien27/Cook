using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq.Expressions;


public class StateOrder : StateAbs
{
    [SerializeField] public float timer = 0;

    public Action OnStart_Order; // event thông báo cho MinoCtrl

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


    protected override void OnEnter() //place implement  logic  ,,give only once signal time
    {
      //  this.ExecuteLogic();
    }





}