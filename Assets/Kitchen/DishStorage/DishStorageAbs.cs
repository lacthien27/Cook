using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishStorageAbs : ThienMonoBehaviour
{
    [SerializeField] protected DishStorageCtrl dishStorageCtrl;

    public DishStorageCtrl DishStorageCtrl  => dishStorageCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDishStorageCtrl();
    }

    protected virtual void LoadDishStorageCtrl()
    {
       if(this.DishStorageCtrl!=null) return;
        this.dishStorageCtrl = transform.parent.GetComponent<DishStorageCtrl>();
        Debug.LogWarning(transform.name +" : Load DishStorageCtrl" ,gameObject);
    }
}
