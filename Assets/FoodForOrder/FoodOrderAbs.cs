using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodOrderAbs : ThienMonoBehaviour
{
    [SerializeField] protected FoodOrderCtrl foodOrderCtrl;

  public FoodOrderCtrl FoodOrderCtrl => foodOrderCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadFoodCtrl();
    }

    protected virtual void LoadFoodCtrl()
    {
        if(this.foodOrderCtrl!=null) return;
        this.foodOrderCtrl = transform.parent.GetComponent<FoodOrderCtrl>();
        Debug.LogWarning(transform.name +" : Load FoodOrderCtrl" ,gameObject);
    }

}
