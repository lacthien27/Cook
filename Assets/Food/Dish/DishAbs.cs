using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishAbs : ThienMonoBehaviour
{
      [SerializeField] protected DishCtrl dishCtrl;

  public DishCtrl DishCtrl => dishCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDishCtrl();
    }

    protected virtual void LoadDishCtrl()
    {
        if(this.dishCtrl!=null) return;
        this.dishCtrl = transform.parent.GetComponent<DishCtrl>();
        Debug.LogWarning(transform.name +" : Load DishCtrl" ,gameObject);
    }

}
