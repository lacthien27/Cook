using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemCombineFoodAbs : ThienMonoBehaviour
{
 [SerializeField] protected SystemCombineFoodCtrl systemCombineFoodCtrl;

  public SystemCombineFoodCtrl SystemCombineFoodCtrl => systemCombineFoodCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSystemCombineFoodCtrl();
    }

    protected virtual void LoadSystemCombineFoodCtrl()
    {
        if(this.systemCombineFoodCtrl!=null) return;
        this.systemCombineFoodCtrl = transform.parent.GetComponent<SystemCombineFoodCtrl>();
        Debug.LogWarning(transform.name +" : Load SystemCombineFoodCtrl" ,gameObject);
    }
}
