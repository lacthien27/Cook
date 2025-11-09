using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarGrillScreening : KitchenScreening
{
     [SerializeField] protected BarGrillCtrl barGrillCtrl;

    public BarGrillCtrl BarGrillCtrl => barGrillCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBarGrillCtrl();
    }

    protected virtual void LoadBarGrillCtrl()
    {
        if (this.barGrillCtrl != null) return;
        this.barGrillCtrl = transform.parent.GetComponent<BarGrillCtrl>();
        Debug.LogWarning(transform.name + " : Load BarGrillCtrl", gameObject);
    }
}
