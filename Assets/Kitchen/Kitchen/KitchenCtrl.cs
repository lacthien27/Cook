using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenCtrl : ThienMonoBehaviour
{
    [SerializeField] protected KitchenArrange kitchenArrange;
    public KitchenArrange KitchenArrange => kitchenArrange;

    [SerializeField] protected KitchenScreening kitchenScreening;
    public KitchenScreening KitchenScreening => kitchenScreening;



    protected override void LoadComponents()
    {
        base.LoadComponents();

        this.LoadKitchenArrange();
        this.LoadKitchenScreening();
    }


    protected virtual void LoadKitchenArrange()
    {
        if (this.kitchenArrange != null) return;
        this.kitchenArrange = GetComponentInChildren<KitchenArrange>();
        Debug.LogWarning(transform.name + " : Load KitchenArrange", gameObject);
    }


    protected virtual void LoadKitchenScreening()
    {
        if (this.kitchenScreening != null) return;
        this.kitchenScreening = GetComponentInChildren<KitchenScreening>();
        Debug.LogWarning(transform.name + " : Load KitchenScreening", gameObject);
    }
}
