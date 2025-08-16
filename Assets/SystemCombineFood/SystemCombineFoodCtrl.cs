using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemCombineFoodCtrl : GameAbs
{

    [SerializeField] protected SystemArrange systemArrange;
    public SystemArrange SystemArrange => systemArrange;


 
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSystemArrange();
    }


    protected virtual void LoadSystemArrange()
    {
        if (this.systemArrange != null) return;
        this.systemArrange = GetComponentInChildren<SystemArrange>();
        Debug.LogWarning(transform.name + " : Load SystemArrange", gameObject);
    }
}
