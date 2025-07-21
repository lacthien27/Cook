using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCookCtrl : ThienMonoBehaviour
{
    [SerializeField] protected FoodCookPro foodCookPro;
    public FoodCookPro FoodCookPro => foodCookPro;

    [SerializeField] protected FoodCookImpact foodCookImpact;
    public FoodCookImpact FoodCookImpact => foodCookImpact;


    public int food = 1;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadFoodProperties();
        this.LoadFoodCookImpact();
    }


    protected virtual void LoadFoodProperties()
    {
        if (this.foodCookPro != null) return;
        this.foodCookPro = GetComponentInChildren<FoodCookPro>();
        Debug.LogWarning(transform.name + " : Load FoodCookPro", gameObject);
    }
    
    protected virtual void LoadFoodCookImpact()
    {
        if (this.foodCookImpact != null) return;
        this.foodCookImpact = GetComponentInChildren<FoodCookImpact>();
        Debug.LogWarning(transform.name + " : Load FoodCookImpact", gameObject);
    }
    
}
