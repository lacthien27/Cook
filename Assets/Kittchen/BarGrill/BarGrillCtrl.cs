using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarGrillCtrl : ThienMonoBehaviour
{
    [SerializeField] protected BarGrillArrange barGrillArrange;
    public BarGrillArrange BarGrillArrange => barGrillArrange;

  

    [SerializeField] protected BarGrillScreening barGrillScreening;
    public BarGrillScreening BarGrillScreening => barGrillScreening;



    protected override void LoadComponents()
    {
        base.LoadComponents();

        this.LoacBarGrillArrange();
        this.LoadBarGillScreening();
    }


    protected virtual void LoacBarGrillArrange()
    {
        if (this.barGrillArrange != null) return;
        this.barGrillArrange = GetComponentInChildren<BarGrillArrange>();
        Debug.LogWarning(transform.name + " : Load BarGrillArrange", gameObject);
    }

   
    
    protected virtual void LoadBarGillScreening()
    {
        if (this.barGrillScreening != null) return;
        this.barGrillScreening = GetComponentInChildren<BarGrillScreening>();
        Debug.LogWarning(transform.name + " : Load BarGrillScreening", gameObject);
    }
}
