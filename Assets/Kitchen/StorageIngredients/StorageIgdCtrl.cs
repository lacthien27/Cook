using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageIgdCtrl : ThienMonoBehaviour
{


    [SerializeField] protected StorageIgdArrange storageIgdArrange;
    public StorageIgdArrange StorageIgdArrange => storageIgdArrange;

    [SerializeField] protected StorageIgdPro storageIgdPro;
    public StorageIgdPro StorageIgdPro => storageIgdPro;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadStorageIgdArrange();
        this.LoadStorageIgdPro();
    }

    protected virtual void LoadStorageIgdPro()
    {
        if (this.storageIgdPro != null) return;
        this.storageIgdPro = GetComponentInChildren<StorageIgdPro>();
        Debug.LogWarning(transform.name + " : Load StorageIgdPro", gameObject);
    }

     protected virtual void LoadStorageIgdArrange()
    {
        if (this.storageIgdArrange != null) return;
        this.storageIgdArrange = GetComponentInChildren<StorageIgdArrange>();
        Debug.LogWarning(transform.name + " : Load StorageIgdArrange", gameObject);
    }

}
