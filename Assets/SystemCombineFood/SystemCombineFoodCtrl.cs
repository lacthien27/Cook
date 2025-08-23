using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemCombineFoodCtrl : GameAbs
{

    [SerializeField] protected SystemArrange systemArrange;
    public SystemArrange SystemArrange => systemArrange;


    [SerializeField] protected SystemCombineFood systemCombineFood;
    public SystemCombineFood SystemCombineFood => systemCombineFood;



    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSystemArrange();
        this.LoadSystemCombineFood();
    }


    protected virtual void LoadSystemCombineFood()
    {
        if (this.systemCombineFood != null) return;
        this.systemCombineFood = GetComponentInChildren<SystemCombineFood>();
        Debug.LogWarning(transform.name + " : Load SystemCombineFood", gameObject);
    }

    protected virtual void LoadSystemArrange()
    {
        if (this.systemArrange != null) return;
        this.systemArrange = GetComponentInChildren<SystemArrange>();
        Debug.LogWarning(transform.name + " : Load SystemArrange", gameObject);
    }
}
