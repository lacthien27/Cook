using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;

public class StatePayed : StateAbs
{
    public static Action OnComplete_Payed; // event thông báo cho MinoCtrl

    protected override void OnEnter()
    {
        this.ExecuteLogic();

    }

    protected virtual void ExecuteLogic()
    {
        OnComplete_Payed?.Invoke();
     //   Debug.LogWarning(" Payed Complete ");
        this.stateMachineCtrl.ChangeState(this.stateMachineCtrl.StateLeave);
    }
    


}
