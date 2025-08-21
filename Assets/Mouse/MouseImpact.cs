using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseImpact : MouseAbs
{

   [SerializeField] public static FoodCookImpact currentObject;
   



   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.transform.parent.GetComponent<FoodCookCtrl>())
      {
         var objCtrl = other.transform.parent.GetComponent<FoodCookCtrl>();
         if (objCtrl.FoodCookPickup.TryGetComponent(out IsPickupAble ObjPickup))
         {
            ObjPickup.isPickup = true;

         }
      }
   }

   private void OnTriggerExit2D(Collider2D other)
   {
        if (other.transform.parent.GetComponent<FoodCookCtrl>())
        {
           var objCtrl = other.transform.parent.GetComponent<FoodCookCtrl>();
           if (objCtrl.FoodCookPickup.TryGetComponent(out IsPickupAble ObjPickup))
           {
              ObjPickup.isPickup = false;
           }
        }
      
      
   }
   

}




