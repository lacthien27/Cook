using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCtrl : ThienMonoBehaviour
{
    [SerializeField] protected FoodPro foodPro;
    public FoodPro FoodPro => foodPro;

    [SerializeField] protected FoodImpact foodImpact;
    public FoodImpact FoodImpact => foodImpact;


    [SerializeField] protected FoodPickup foodPickup;
    public FoodPickup FoodPickup => foodPickup;


    [SerializeField] protected FoodMove foodMove;
    public FoodMove FoodMove => foodMove;

    [SerializeField] protected FoodTurnOff foodTurnOff;
    public FoodTurnOff FoodTurnOff => foodTurnOff;
 [SerializeField] protected FoodState foodState;
    public FoodState FoodState => foodState;


   [SerializeField] protected FoodTimer foodTimer;

    public FoodTimer FoodTimer => foodTimer;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadFoodProperties();
        this.LoadFoodImpact();
        this.LoadFoodMove();
        this.LoadFoodPickup();
        this.LoadFoodTurnOff();
       this.LoadFoodState();
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
    }

    protected virtual void LoadFoodTurnOff()
    {
        if (this.foodTurnOff != null) return;
        this.foodTurnOff = GetComponentInChildren<FoodTurnOff>();
        Debug.LogWarning(transform.name + " : Load FoodTurnOff", gameObject);
    }

    protected virtual void LoadFoodMove()
    {
        if (this.foodMove != null) return;
        this.foodMove = GetComponentInChildren<FoodMove>();
        Debug.LogWarning(transform.name + " : Load FoodMove", gameObject);
    }

    protected virtual void LoadFoodPickup()
    {
        if (this.foodPickup != null) return;
        this.foodPickup = GetComponentInChildren<FoodPickup>();
        Debug.LogWarning(transform.name + " : Load FoodPickup", gameObject);
    }


    protected virtual void LoadFoodProperties()
    {
        if (this.foodPro != null) return;
        this.foodPro = GetComponentInChildren<FoodPro>();
        Debug.LogWarning(transform.name + " : Load FoodPro", gameObject);
    }
    
    protected virtual void LoadFoodImpact()
    {
        if (this.foodImpact != null) return;
        this.foodImpact = GetComponentInChildren<FoodImpact>();
        Debug.LogWarning(transform.name + " : Load FoodImpact", gameObject);
    }
    
}
