using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class NpcReceiveFood : NpcAbs
{

  public virtual void CompareFood(FoodImpact FoodImpact)
  {
    var foodPro = FoodImpact.FoodCtrl.FoodPro;
    if (!this.npcCtrl.NpcOrder.foodDataToObjects.ContainsKey(foodPro.FoodData)) return;//check foodCookpro.FoodData belong to foodDataToObjects, nếu ko có thì return
    FoodImpact.foodAsOrderd = true;   //condition to turn off FoodCookTurnOff
    List<Transform> list = this.npcCtrl.NpcOrder.foodDataToObjects[foodPro.FoodData];// list objects that have the same foodData of npcCtrl.NpcOrder
    foreach (Transform foodTransform in list)
    {
      if (foodTransform.transform.name != foodPro.transform.parent.name) return;// so sánh name of foodOrer vs foodCoook
      var foodOrderTurnOff = foodTransform.GetComponentInChildren<FoodOrderTurnOff>();
      foodOrderTurnOff.isCorrectOrder = true;
      return;
    }

  }

 


}
