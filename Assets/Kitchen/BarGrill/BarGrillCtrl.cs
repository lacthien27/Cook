using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarGrillCtrl : ThienMonoBehaviour
{
   [SerializeField] protected BarGrillArrange barGrillArrange;
    public BarGrillArrange BarGrillArrange => barGrillArrange;

    [SerializeField] protected BarGrillScreening barGrillScreening;
    public BarGrillScreening BarGrillScreening => barGrillScreening;

    [SerializeField] protected BarGrillState barGrillState;

    public BarGrillState BarGrillState => barGrillState;

    [SerializeField] protected BarGrillRefuelSta barGrillRefuelSta;
    public BarGrillRefuelSta BarGrillRefuelSta => barGrillRefuelSta;


    protected override void LoadComponents()
    {
        base.LoadComponents();

        this.LoadBarGrillArrange();
        this.LoadBarGrillScreening();
        this.LoadBarGrillState();
        this.LoadBarGrillRefuelSta();
    }
    protected virtual void LoadBarGrillRefuelSta()
    {
        if (this.barGrillRefuelSta != null) return;
        this.barGrillRefuelSta = GetComponentInChildren<BarGrillRefuelSta>();
        Debug.LogWarning(transform.name + " : Load BarGrillRefuelSta", gameObject);
    }

    protected virtual void LoadBarGrillState()
    {
        if (this.barGrillState != null) return;
        this.barGrillState = GetComponentInChildren<BarGrillState>();
        Debug.LogWarning(transform.name + " : Load BarGrillState", gameObject);
    }

    protected virtual void LoadBarGrillArrange()
    {
        if (this.barGrillArrange != null) return;
        this.barGrillArrange = GetComponentInChildren<BarGrillArrange>();
        Debug.LogWarning(transform.name + " : Load BarGrillArrange", gameObject);
    }


    protected virtual void LoadBarGrillScreening()
    {
        if (this.barGrillScreening != null) return;
        this.barGrillScreening = GetComponentInChildren<BarGrillScreening>();
        Debug.LogWarning(transform.name + " : Load BarGrillScreening", gameObject);
    }

}
