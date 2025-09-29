using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StateMove : StateAbs
{
    [SerializeField] public float timer = 0;

    public  Action OnComplete_Moved;

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
            var VacantPos = GameCtrl.Instance.ArrangeNpc.GetRandomAvailablePosition();
            GameCtrl.Instance.ArrangeNpc.AssignNpcToPosition(this.stateMachineCtrl.NpcCtrl.gameObject, VacantPos);
            this.timer = 0;
            OnComplete_Moved?.Invoke();
        }

    }

    protected override void OnExit()
    {
        //OnComplete_Moved -= ExecuteLogic;
    }

    



    
}
