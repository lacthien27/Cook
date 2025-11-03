using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class NpcCheckOrders : NpcAbs
{
    [SerializeField] protected List<Transform> listOrders = new List<Transform>();

    [SerializeField] public bool isReceiveAllOrders = false;

    protected override void OnEnable()
    {
        base.OnEnable();
        this.isReceiveAllOrders = false;
    }


    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.transform.name == "OrderImpact")
        {

            var dish = other.transform.parent;
            listOrders.Add(dish);


        }
    }


    protected virtual void OnTriggerExit2D(Collider2D other)
    {

        if (other.transform.name == "OrderImpact")
        {
            var dish = other.transform.parent;
            listOrders.Remove(dish);
            this.CheckOrder(); 
        }
    } 



    protected virtual void CheckOrder()
    {
        if (listOrders.Count != 0) return;
       Debug.Log("Đã giao hết đơn hàng cho NPC");
        isReceiveAllOrders = true;   
       
    }
}
