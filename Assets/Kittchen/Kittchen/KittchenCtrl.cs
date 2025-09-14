using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittchenCtrl : ThienMonoBehaviour
{
    [SerializeField] protected KittchenArrange kittchenArrange;
    public KittchenArrange KittchenArrange => kittchenArrange;

  

    [SerializeField] protected KittchenScreening kittchenScreening;
    public KittchenScreening KittchenScreening => kittchenScreening;



    protected override void LoadComponents()
    {
        base.LoadComponents();

        this.LoacKittchenArrange();
        this.LoadKittchenScreening();
    }


    protected virtual void LoacKittchenArrange()
    {
        if (this.kittchenArrange != null) return;
        this.kittchenArrange = GetComponentInChildren<KittchenArrange>();
        Debug.LogWarning(transform.name + " : Load KittchenArrange", gameObject);
    }

   
    
    protected virtual void LoadKittchenScreening()
    {
        if (this.kittchenScreening != null) return;
        this.kittchenScreening = GetComponentInChildren<KittchenScreening>();
        Debug.LogWarning(transform.name + " : Load KittchenScreening", gameObject);
    }
}
