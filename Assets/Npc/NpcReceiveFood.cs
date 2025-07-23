using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class NpcReceiveFood : NpcAbs
{
  public virtual void CompareFood(FoodCookImpact FoodCookImpact)
  {
    var foodCookpro = FoodCookImpact.FoodCookCtrl.FoodCookPro;
   // if (!this.NpcCtrl.NpcOrder.foodOrders.Contains(foodCookpro.FoodData)) return;//checkfoodCookpro.FoodData belong list of food orders ,nếu ko có thì return
    //  FoodCookImpact.foodAsOrderd = true;  //condition to turn off FoodCookTurnOff
    if (!this.npcCtrl.NpcOrder.foodDataToObjects.ContainsKey(foodCookpro.FoodData)) return;//check foodCookpro.FoodData belong to foodDataToObjects, nếu ko có thì return
      FoodCookImpact.foodAsOrderd = true;
      List<Transform> list= this.npcCtrl.NpcOrder.foodDataToObjects[foodCookpro.FoodData];
      foreach (Transform foodTransform in list)
        {
        if (foodTransform.transform.name != foodCookpro.transform.parent.name) return;
        var foodOrderTurnOff = foodTransform.GetComponentInChildren<FoodOrderTurnOff>();
        foodOrderTurnOff.isCorrectOrder = true;
        return;
        }
 
  }
   
}
