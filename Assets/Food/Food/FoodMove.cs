using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class FoodMove : MoveObjAbs
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
