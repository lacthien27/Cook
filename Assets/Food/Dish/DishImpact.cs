using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishImpact : DishAbs
{
   
    [SerializeField] public bool foodAsOrderd = false;// let the outside function use

    [SerializeField] protected Collider2D cl2D;
    public Collider2D Cl2D => cl2D;


    [SerializeField] public Rigidbody2D rb2D;
    public Rigidbody2D Rb2D => rb2D;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCollider2D();
        this.LoadRigidbody2D();
    }


    protected virtual void OnTriggerEnter2D(Collider2D other)
    {

        if (other.transform.parent.GetComponent<DishCtrl>())
        {
            var objCtrl = other.transform.parent.GetComponent<DishCtrl>();
            if (objCtrl.DishPickUp.TryGetComponent(out IsPickupAble ObjPickup))
            {
                if (ObjPickup.isAreaMouse == true) return;  // if the object is already in the area impact, thì cứ cho nó di chuyển
                ObjPickup.isPickUp = true;              //if object is not in the area impact, will not allow to  move 



            }
        }

       
      


    }

    protected virtual void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.parent.GetComponent<DishCtrl>())
        {
            var objCtrl = other.transform.parent.GetComponent<DishCtrl>();
            if (objCtrl.DishPickUp.TryGetComponent(out IsPickupAble ObjPickup))
            {

            }
        }
      

    }



    protected virtual void LoadRigidbody2D()
    {
        if (this.rb2D != null) return;
        this.rb2D = GetComponentInChildren<Rigidbody2D>();
        Debug.LogWarning(transform.name + " : Load Rigidbody2D", gameObject);
    }

    protected virtual void LoadCollider2D()
    {
        if (this.cl2D != null) return;
        this.cl2D = GetComponentInChildren<Collider2D>();
        Debug.LogWarning(transform.name + " : Load Collider2D", gameObject);
    }

}
