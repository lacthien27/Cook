using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenCtrl : ThienMonoBehaviour
{
    [SerializeField] protected KitchenArrange kitchenArrange;
    public KitchenArrange KitchenArrange => kitchenArrange;

    [SerializeField] protected KitchenScreening kitchenScreening;
    public KitchenScreening KitchenScreening => kitchenScreening;

    [SerializeField] protected KitchenState kitchenState;

    public KitchenState KitchenState => kitchenState;


    protected override void LoadComponents()
    {
        base.LoadComponents();

        this.LoadKitchenArrange();
        this.LoadKitchenScreening();
        this.LoadKitchenState();
    }

    protected virtual void LoadKitchenState()
    {
        if (this.kitchenState != null) return;
        this.kitchenState = GetComponentInChildren<KitchenState>();
        Debug.LogWarning(transform.name + " : Load KitchenState", gameObject);
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
