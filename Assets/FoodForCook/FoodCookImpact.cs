using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class FoodCookImpact : FoodCookAbs
{

    [SerializeField] public bool  foodAsOrderd = false;// let the outside function use

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


    protected virtual void OnTriggerEnter2D(Collider2D other)
    {

        if (MouseImpact.currentObject != null) return;
        var mouse = other.gameObject.transform.GetComponent<MouseImpact>(); // if there is already a currentObject, do not set this one
        if (mouse != null)
        {
            MouseImpact.currentObject = this; // set currentObject to FoodCookImpact when mouse enters the impact zone
        }




    }

    protected virtual void OnTriggerExit2D(Collider2D other)
    {
        var mouse = other.gameObject.transform.GetComponent<MouseImpact>(); // if there is already a currentObject, do not set this one
        if (mouse != null && MouseImpact.currentObject == this)// help reset the currentObject when mouse exits the impact zone

            MouseImpact.currentObject = null;

        
    }
    
   
     
}
