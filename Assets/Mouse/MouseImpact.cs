using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseImpact : MouseAbs
{

   [SerializeField] public static FoodImpact currentObject;
   
   [SerializeField] private bool hasPicked = false;// do not drag 1 time 2 object

   private void OnTriggerEnter2D(Collider2D other)
   {
          if (hasPicked) return; // đã pick 1 object rồi thì bỏ qua

      if (other.transform.parent.GetComponent<FoodCtrl>())
      {
         var objCtrl = other.transform.parent.GetComponent<FoodCtrl>();
         if (objCtrl.FoodPickup.TryGetComponent(out IsPickupAble ObjPickup))
         {
            ObjPickup.isAreaMouse = true;
            hasPicked = true; // gắn cờ


         }
      }
   }

   private void OnTriggerExit2D(Collider2D other)
   {
        if (other.transform.parent.GetComponent<FoodCtrl>())
        {
           var objCtrl = other.transform.parent.GetComponent<FoodCtrl>();
         if (objCtrl.FoodPickup.TryGetComponent(out IsPickupAble ObjPickup))
         {
            ObjPickup.isAreaMouse = false;
                          hasPicked = false; // gắn cờ

           }
        }
      
      
   }
   

}




