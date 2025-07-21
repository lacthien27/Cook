using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class FoodCookImpact : FoodCookAbs
{

    [SerializeField] public bool  foodAsOrderd = false;// let the outside function use

   protected virtual void OnTriggerEnter2D(Collider2D other)

    {
        if(MouseImpact.currentObject !=null) return;
        var mouse = other.gameObject.transform.GetComponent<MouseImpact>(); // if there is already a currentObject, do not set this one
        if (mouse!=null)
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
