using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcCtrl : GameAbs
{

    [SerializeField] protected NpcOrder npcOrder;
    public NpcOrder NpcOrder => npcOrder;

    [SerializeField] protected NpcMove npcMove;
    public NpcMove NpcMove => npcMove;

    [SerializeField] protected NpcImpact npcImpact;
    public NpcImpact NpcImpact => npcImpact;

    [SerializeField] protected NpcReceiveFood npcReceiveFood;
    public NpcReceiveFood NpcReceiveFood => npcReceiveFood;

    [SerializeField] protected StateMachineCtrl stateMachineCtrl;
    public StateMachineCtrl StateMachineCtrl => stateMachineCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadNpcMove();
        this.LoadNpcOrder();
                //this.NpcImpact.enabled = true;

        this.LoadNpcImpact();
        this.LoadNpcReceiveFood();
        this.LoadStateMachineCtrl();
    }

    protected virtual void LoadStateMachineCtrl()
    {
        if (this.stateMachineCtrl != null) return;
        this.stateMachineCtrl = GetComponentInChildren<StateMachineCtrl>();
        Debug.LogWarning(transform.name + " : Load StateMachineCtrl", gameObject);
    }

    protected virtual void LoadNpcOrder()
    {
        if (this.npcOrder != null) return;
        this.npcOrder = GetComponentInChildren<NpcOrder>();
        Debug.LogWarning(transform.name + " : Load NpcOrder", gameObject);
    }


    protected virtual void LoadNpcMove()
    {
        if (this.npcMove != null) return;
        this.npcMove = GetComponentInChildren<NpcMove>();
        Debug.LogWarning(transform.name + " : Load NpcMove", gameObject);
    }


    protected virtual void LoadNpcImpact()
    {
        if (this.npcImpact != null) return;
        this.npcImpact = GetComponentInChildren<NpcImpact>();
        Debug.LogWarning(transform.name + " : Load NpcImpact", gameObject);
    }

    protected virtual void LoadNpcReceiveFood()
    {
        if (this.npcReceiveFood != null) return;
        this.npcReceiveFood = GetComponentInChildren<NpcReceiveFood>();
        Debug.LogWarning(transform.name + " : Load NpcReceiveFood", gameObject);
    }


}
