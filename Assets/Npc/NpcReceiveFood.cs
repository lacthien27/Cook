using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.IO.LowLevel.Unsafe;



public class NpcReceiveFood : NpcAbs
{
  [SerializeField] public bool CorrectOrder; //use cho các transform belong npc 

  public virtual void Notused_CompareFood(DishImpact dishImpact)
  {
    var dishPro = dishImpact.DishCtrl.DishPro;
    if (!this.npcCtrl.NpcOrder.foodDataToObjects.ContainsKey(dishPro.FoodData)) return;//check foodCookpro.FoodData belong to foodDataToObjects, nếu ko có thì return
    //this.ConditionToTurnOffDish(dishPro, dishImpact); // turn off FoodCookTurnOff

    List<Transform> list = this.npcCtrl.NpcOrder.foodDataToObjects[dishPro.FoodData];// list transform of npcOrder reference form directory foodDataToObjects
    foreach (Transform dishTransform in list)
    {
      if (dishTransform.transform.name != dishPro.transform.parent.name) return;// so sánh name of foodOrer vs dish

      var disTurnOff = dishPro.DishCtrl.DishTurnOff;  // turnOff Dish
      disTurnOff.isCorrectOrder = true;

      var foodOrderTurnOff = dishTransform.GetComponentInChildren<FoodOrderTurnOff>();
      this.CorrectOrder = true;       // swtich state
      foodOrderTurnOff.isCorrectOrder = true;   //turnoff FoodOrder

      return;
    }

  }


  public virtual void CompareFood(DishImpact dishImpact)
  {
    var dishPro = dishImpact.DishCtrl.DishPro;
    if (this.npcCtrl.NpcOrder.foodDataToObjects.TryGetValue(dishPro.FoodData, out var list)) // check foodCookpro.FoodData belong to foodDataToObjects, nếu ko có thì return
    {
      foreach (Transform dishTransform in list)
      {
        if (dishTransform.transform.name != dishPro.transform.parent.name) return;// so sánh name of foodOrer vs dish
        this.TurnOffDish(dishPro); // turn off FoodCookTurnOff
        this.TurnOffFoodOrder(dishTransform);  // turn off FoodOrderTurnOff

         this.CorrectOrder = true;           // swtich state

        this.npcCtrl.NpcOrder.foodOrders.Remove(dishPro.FoodData); // not influence to logic, only use to count amount of foodOrder
        this.npcCtrl.NpcOrder.foodDataToObjects.Remove(dishPro.FoodData);   // remove the key-value pair from the dictionary
      }
    }
  }


  protected virtual void TurnOffDish(DishPro dishPro)
  {
    var disTurnOff = dishPro.DishCtrl.DishTurnOff;  // turnOff Dish
    disTurnOff.isCorrectOrder = true;
  }
  

  protected virtual void TurnOffFoodOrder(Transform dishTransform)
  {
    var foodOrderTurnOff = dishTransform.GetComponentInChildren<FoodOrderTurnOff>(); 
      foodOrderTurnOff.isCorrectOrder = true; 
  }












}
