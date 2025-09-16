using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodAbs : ThienMonoBehaviour
{
    [SerializeField] protected FoodCtrl foodCtrl;

  public FoodCtrl FoodCtrl => foodCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadFoodCtrl();
    }

    protected virtual void LoadFoodCtrl()
    {
        if(this.foodCtrl!=null) return;
        this.foodCtrl = transform.parent.GetComponent<FoodCtrl>();
        Debug.LogWarning(transform.name +" : Load FoodCtrl" ,gameObject);
    }

}
