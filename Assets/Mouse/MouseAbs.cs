using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAbs : ThienMonoBehaviour
{
     [SerializeField] protected MouseCtrl mouseCtrl;

  public MouseCtrl MouseCtrl => mouseCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadMouseCtrl();
    }

    protected virtual void LoadMouseCtrl()
    {
        if(this.mouseCtrl!=null) return;
        this.mouseCtrl = transform.parent.GetComponent<MouseCtrl>();
        Debug.LogWarning(transform.name +" : Load MouseCtrl" ,gameObject);
    }

}
