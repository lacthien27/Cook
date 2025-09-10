using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarGrillCtrl : ThienMonoBehaviour
{
    [SerializeField] protected BarGrillArrange barGrillArrange;
    public BarGrillArrange BarGrillArrange => barGrillArrange;




    protected override void LoadComponents()
    {
        base.LoadComponents();
       
        this.LoacBarGrillArrange();
    }

    
    protected virtual void LoacBarGrillArrange()
    {
        if (this.barGrillArrange != null) return;
        this.barGrillArrange = GetComponentInChildren<BarGrillArrange>();
        Debug.LogWarning(transform.name + " : Load BarGrillArrange", gameObject);
    }
}
