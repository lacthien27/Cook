using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;
using System;


public class NpcImpact : NpcAbs
{

  protected virtual void OnTriggerEnter2D(Collider2D other)
  {

   if (other.GetComponent<DishImpact>() != null)
    {
      var dishImpact = other.GetComponent<DishImpact>();
      this.NpcCtrl.NpcReceiveFood.CompareFood(dishImpact);//call NpcRecveive handle// có nên đặt ở đây ko ???
          
    }

  }


  protected virtual void OnTriggerExit2D(Collider2D other)
  {
    if (other.GetComponent<FoodImpact>() != null)
    {
      var foodImpact = other.GetComponent<FoodImpact>();
      foodImpact.foodAsOrderd = false; // Reset the order correctness flag when exiting the trigger  
    }
    

  }


}
