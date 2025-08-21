using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCookCtrl : ThienMonoBehaviour
{
    [SerializeField] protected FoodCookPro foodCookPro;
    public FoodCookPro FoodCookPro => foodCookPro;

    [SerializeField] protected FoodCookImpact foodCookImpact;
    public FoodCookImpact FoodCookImpact => foodCookImpact;


    [SerializeField] protected FoodCookPickup foodCookPickup;
    public FoodCookPickup FoodCookPickup => foodCookPickup;


    [SerializeField] protected FoodCookMove foodCookMove;
    public FoodCookMove FoodCookMove => foodCookMove;

    public int food = 1;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadFoodProperties();
        this.LoadFoodCookImpact();
        this.LoadFoodCookMove();
        this.LoadFoodCookPickup();
    }

    protected virtual void LoadFoodCookMove()
    {
        if (this.foodCookMove != null) return;
        this.foodCookMove = GetComponentInChildren<FoodCookMove>();
        Debug.LogWarning(transform.name + " : Load FoodCookMove", gameObject);
    }

    protected virtual void LoadFoodCookPickup()
    {
        if (this.foodCookPickup != null) return;
        this.foodCookPickup = GetComponentInChildren<FoodCookPickup>();
        Debug.LogWarning(transform.name + " : Load FoodCookPickUp", gameObject);
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
