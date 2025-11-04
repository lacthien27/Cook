using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcoalCtrl : ThienMonoBehaviour
{
    [SerializeField] protected CharcoalImpact charcoalImpact;
   
    public CharcoalImpact CharcoalImpact => charcoalImpact;


   [SerializeField] protected CharcoalTurnOff charcoalTurnOff;

    public CharcoalTurnOff CharcoalTurnOff => charcoalTurnOff;

    [SerializeField] protected CharcoalMove charcoalMove;
    public CharcoalMove CharcoalMove => charcoalMove;

    [SerializeField] public CharcoalPickup CharcoalPickup;
    public CharcoalPickup CharcoalPickUp => CharcoalPickup;



    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCharcoalImpact();
        this.LoadCharcoalTurnOff();
        this.LoadCharcoalMove();
        this.LoadCharcoalPickup();
    }
    
    protected virtual void LoadCharcoalPickup()
    {
        if (this.CharcoalPickup != null) return;
        this.CharcoalPickup = GetComponentInChildren<CharcoalPickup>();
        Debug.LogWarning(transform.name + " : Load CharcoalPickup", gameObject);
    }

    protected virtual void LoadCharcoalMove()
    {
        if (this.charcoalMove != null) return;
        this.charcoalMove = GetComponentInChildren<CharcoalMove>();
        Debug.LogWarning(transform.name + " : Load CharcoalMove", gameObject);
    }

    protected virtual void LoadCharcoalImpact()
    {
        if (this.charcoalImpact != null) return;
        this.charcoalImpact = GetComponentInChildren<CharcoalImpact>();
        Debug.LogWarning(transform.name + " : Load CharcoalImpact", gameObject);
    }

    protected virtual void LoadCharcoalTurnOff()
    {
        if (this.charcoalTurnOff != null) return;
        this.charcoalTurnOff = GetComponentInChildren<CharcoalTurnOff>();
        Debug.LogWarning(transform.name + " : Load CharcoalTurnOff", gameObject);
    }
}
