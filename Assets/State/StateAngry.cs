using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAngry : StateAbs
{
    [SerializeField] public float timer = 0;

     protected override void OnUpdate()
    {

        this.ExecuteLogic();
    }
    protected virtual void ExecuteLogic()
    {
        this.timer += Time.deltaTime;
        if (timer < 1000f)  //dưới 4 giây và phải has enough food
        {
            this.stateMachineCtrl.ChangeState(this.stateMachineCtrl.StatePayed);
            Debug.LogWarning("Change to StatePayed from Angry");

        }
        else
        {
            this.stateMachineCtrl.ChangeState(this.stateMachineCtrl.StateLeave);
            Debug.Log("leave because angry");
        }   

    }
    
}
