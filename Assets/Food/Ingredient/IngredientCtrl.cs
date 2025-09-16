using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientCtrl : FoodCtrl
{
  /**  [SerializeField] protected FoodTimer foodTimer;

    public FoodTimer FoodTimer => foodTimer;

     [SerializeField] protected FoodState foodState;
    public FoodState FoodState => foodState;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadFoodTimer();
    }



    protected virtual void LoadFoodTimer()
    {
        if (this.foodTimer != null) return;
        this.foodTimer = GetComponentInChildren<FoodTimer>();
        Debug.LogWarning(transform.name + " : Load FoodTimer", gameObject);
    }
    

      protected virtual void LoadFoodState()
    {
        if (this.foodState != null) return;
        this.foodState = GetComponentInChildren<FoodState>();
        Debug.LogWarning(transform.name + " : Load FoodState", gameObject);
    }**/
}
