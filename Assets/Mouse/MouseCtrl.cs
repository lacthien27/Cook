using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCtrl : GameAbs
{
    [SerializeField] protected MousePos mousePos;
    public MousePos MousePos => mousePos;

 [SerializeField] protected MouseImpact mouseImpact;
    public MouseImpact MouseImpact => mouseImpact;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadMousePos();
        this.LoadMouseImpact();
    }

    protected virtual void LoadMouseImpact()
    {
        if (this.mouseImpact != null) return;
        this.mouseImpact = GetComponentInChildren<MouseImpact>();
        Debug.LogWarning(transform.name + " : Load MouseImpact", gameObject);
    }

    protected virtual void LoadMousePos()
    {
        if (this.mousePos != null) return;
        this.mousePos = GetComponentInChildren<MousePos>();
        Debug.LogWarning(transform.name + " : Load MousePos", gameObject);
    }

   
}
