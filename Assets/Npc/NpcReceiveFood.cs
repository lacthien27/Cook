using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class NpcReceiveFood : NpcAbs
{
  [SerializeField] public bool CorrectOrder; //use cho các transform belong npc 

  public virtual void CompareFood(DishImpact dishImpact)
  {
    var dishPro = dishImpact.DishCtrl.DishPro;
    if (!this.npcCtrl.NpcOrder.foodDataToObjects.ContainsKey(dishPro.FoodData)) return;//check foodCookpro.FoodData belong to foodDataToObjects, nếu ko có thì return
    dishImpact.foodAsOrderd = true;   //condition to turn off FoodCookTurnOff
    List<Transform> list = this.npcCtrl.NpcOrder.foodDataToObjects[dishPro.FoodData];// list objects that have the same foodData of npcCtrl.NpcOrder
    foreach (Transform dishTransform in list)
    {
      if (dishTransform.transform.name != dishPro.transform.parent.name) return;// so sánh name of foodOrer vs dish

      var disTurnOff = dishPro.DishCtrl.DishTurnOff;  // turnOff Dish
      disTurnOff.isCorrectOrder = true;

      var foodOrderTurnOff = dishTransform.GetComponentInChildren<FoodOrderTurnOff>();
      this.CorrectOrder = true;       // swtich State
      foodOrderTurnOff.isCorrectOrder = true;   //turnoff FoodOrder

      return;
    }

  }

 


}
