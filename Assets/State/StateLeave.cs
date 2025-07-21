using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class StateLeave : StateAbs
{
    // Start is called before the first frame update
    public static Action OnComplete_Leave; // event thông báo cho MinoCtrl

    protected override void OnEnter()
    {
        this.ExecuteLogic();

    }

    protected virtual void ExecuteLogic()
    {
        OnComplete_Leave?.Invoke();
    }

}
