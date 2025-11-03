using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageIgdAbs : ThienMonoBehaviour
{

 [SerializeField] protected StorageIgdCtrl storageIgdCtrl;

  public StorageIgdCtrl StorageIgdCtrl => storageIgdCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadStorageIgdCtrl();
    }

    protected virtual void LoadStorageIgdCtrl()
    {
        if(this.storageIgdCtrl!=null) return;
        this.storageIgdCtrl = transform.parent.GetComponent<StorageIgdCtrl>();
        Debug.LogWarning(transform.name +" : Load StorageIgdCtrl" ,gameObject);
    }
}
