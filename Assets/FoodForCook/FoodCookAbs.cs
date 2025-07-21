using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCookAbs : ThienMonoBehaviour
{
    [SerializeField] protected FoodCookCtrl foodCookCtrl;

  public FoodCookCtrl FoodCookCtrl => foodCookCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadFoodCookCtrl();
    }

    protected virtual void LoadFoodCookCtrl()
    {
        if(this.foodCookCtrl!=null) return;
        this.foodCookCtrl = transform.parent.GetComponent<FoodCookCtrl>();
        Debug.LogWarning(transform.name +" : Load FoodCookCtrl" ,gameObject);
    }

}
