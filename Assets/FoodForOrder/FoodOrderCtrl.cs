using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodOrderCtrl : ThienMonoBehaviour
{
    [SerializeField] protected FoodOrderPro foodOrderPro;
    public FoodOrderPro FoodOrderPro => foodOrderPro;

    [SerializeField] protected FollowNpc followNpc;
    public FollowNpc FollowNpc => followNpc;


    public int food = 1;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadFoodProperties();
        this.LoadFollowNpc();
    }


    protected virtual void LoadFoodProperties()
    {
        if (this.foodOrderPro != null) return;
        this.foodOrderPro = GetComponentInChildren<FoodOrderPro>();
        Debug.LogWarning(transform.name + " : Load FoodOrderPro", gameObject);
    }

    protected virtual void LoadFollowNpc()
    {
        if (this.followNpc != null) return;
        this.followNpc = GetComponentInChildren<FollowNpc>();
        Debug.LogWarning(transform.name + " : Load FollowNpc", gameObject);
    }
}
