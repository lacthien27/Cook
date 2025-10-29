using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;



public class NpcReceiveFood : NpcAbs
{
  [SerializeField] public bool CorrectOrder; //use cho các transform belong npc 


  public virtual void CompareFood(DishImpact dishImpact)
  {


    var dishPro = dishImpact.DishCtrl.DishPro;
    if (this.npcCtrl.NpcOrder.foodDataToObjects.TryGetValue(dishPro.FoodData, out var list)) // check foodCookpro.FoodData belong to foodDataToObjects, nếu ko có thì return
    {
     for (int i = 0; i < list.Count; i++)
      {
        Transform dishTransform = list[i];
        if (dishTransform.transform.name != dishPro.transform.parent.name) continue;  // nếu tên ko đúng thì tiếp tục vòng lặp
          this.TurnOffDish(dishPro); // turn off FoodCookTurnOff
          this.TurnOffFoodOrder(dishTransform);  // turn off FoodOrderTurnOff
          list.RemoveAt(i);
          if (list.Count != 0) continue;
          this.npcCtrl.NpcOrder.foodDataToObjects.Remove(dishPro.FoodData);
          return;
      }
    }

    else
    {
      Debug.LogWarning("Wrong Order");
      var dishmove = dishImpact.DishCtrl.DishMove.GetComponent<DishMove>();
      dishmove.isCombinedArea = false;
      dishmove.ReturnToStartPos(); // dish move về vị trí ban đầu
      return;
    }
  }


  protected virtual void TurnOffDish(DishPro dishPro)
  {
    var disTurnOff = dishPro.DishCtrl.DishTurnOff;  // turnOff Dish
    disTurnOff.isCorrectOrder = true;
  }


  protected virtual void TurnOffFoodOrder(Transform foodOrder)
  {
    var foodOrderTurnOff = foodOrder.GetComponentInChildren<FoodOrderTurnOff>();
    foodOrderTurnOff.isCorrectOrder = true;
  }

}



/** [SerializeField] public bool CorrectOrder; //use cho các transform belong npc 


  public virtual void CompareFood(DishImpact dishImpact)
  {

    
    var dishPro = dishImpact.DishCtrl.DishPro;
    if (this.npcCtrl.NpcOrder.foodDataToObjects.TryGetValue(dishPro.FoodData, out var list)) // check foodCookpro.FoodData belong to foodDataToObjects, nếu ko có thì return
    {
      Debug.LogWarning("Correct Order for " + dishPro.FoodData);
      foreach (Transform dishTransform in list) // duyệt qua list order của npc
      {

        if (dishTransform.transform.name == dishPro.transform.parent.name)
        {
          this.TurnOffDish(dishPro); // turn off FoodCookTurnOff
          this.TurnOffFoodOrder(dishTransform);  // turn off FoodOrderTurnOff
          
          //this.npcCtrl.NpcOrder.foodOrders.Remove(dishPro.FoodData); // not influence to logic, only use to count amount of foodOrder
          this.npcCtrl.NpcOrder.foodDataToObjects.Remove(dishPro.FoodData);
          return;
        }
      }

    }

    else
    {
      Debug.LogWarning("Wrong Order");
      var dishmove = dishImpact.DishCtrl.DishMove.GetComponent<DishMove>();
      dishmove.isCombinedArea = false;
      dishmove.ReturnToStartPos(); // dish move về vị trí ban đầu
      return;
    }
  }


  protected virtual void TurnOffDish(DishPro dishPro)
  {
    var disTurnOff = dishPro.DishCtrl.DishTurnOff;  // turnOff Dish
    disTurnOff.isCorrectOrder = true;
  }
  

  protected virtual void TurnOffFoodOrder(Transform foodOrder)
  {
    var foodOrderTurnOff = foodOrder.GetComponentInChildren<FoodOrderTurnOff>(); 
      foodOrderTurnOff.isCorrectOrder = true; 
  }
  **/








