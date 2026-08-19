using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiceCookerAbs : ThienMonoBehaviour
{
   [SerializeField] protected RiceCookerCtrl riceCookerCtrl;

    public RiceCookerCtrl RiceCookerCtrl  => riceCookerCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRiceCookerCtrl();
    }

    protected virtual void LoadRiceCookerCtrl()
    {
       if(this.riceCookerCtrl!=null) return;
        this.riceCookerCtrl = transform.parent.GetComponent<RiceCookerCtrl>();
        Debug.LogWarning(transform.name +" : Load RiceCookerCtrl" ,gameObject);
    }
}
