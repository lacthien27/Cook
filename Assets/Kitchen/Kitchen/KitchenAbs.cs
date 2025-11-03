using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenAbs : ThienMonoBehaviour
{
   [SerializeField] protected KitchenCtrl kitchenCtrl;

  public KitchenCtrl KitchenCtrl => kitchenCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadKitchenCtrl();
    }

    protected virtual void LoadKitchenCtrl()
    {
        if(this.kitchenCtrl!=null) return;
        this.kitchenCtrl = transform.parent.GetComponent<KitchenCtrl>();
        Debug.LogWarning(transform.name +" : Load KitchenCtrl" ,gameObject);
    }
}
