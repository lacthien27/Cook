using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittchenAbs : ThienMonoBehaviour
{
   [SerializeField] protected KittchenCtrl kittchenCtrl;

  public KittchenCtrl KittchenCtrl => kittchenCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadKittchenCtrl();
    }

    protected virtual void LoadKittchenCtrl()
    {
        if(this.kittchenCtrl!=null) return;
        this.kittchenCtrl = transform.parent.GetComponent<KittchenCtrl>();
        Debug.LogWarning(transform.name +" : Load KittchenCtrl" ,gameObject);
    }
}
