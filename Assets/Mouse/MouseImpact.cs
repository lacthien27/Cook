using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseImpact : MouseAbs
{

   [SerializeField] public static FoodCookImpact currentObject;
   
   [SerializeField] private bool hasPicked = false;

   private void OnTriggerEnter2D(Collider2D other)
   {
          if (hasPicked) return; // đã pick 1 object rồi thì bỏ qua

      if (other.transform.parent.GetComponent<FoodCookCtrl>())
      {
         var objCtrl = other.transform.parent.GetComponent<FoodCookCtrl>();
         if (objCtrl.FoodCookPickup.TryGetComponent(out IsPickupAble ObjPickup))
         {
            ObjPickup.isAreaImpact = true;
            hasPicked = true; // gắn cờ


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
            ObjPickup.isAreaImpact = false;
                          hasPicked = false; // gắn cờ

           }
        }
      
      
   }
   

}




