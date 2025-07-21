using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class NpcReceiveFood : NpcAbs
{

  // [SerializeField] public bool isCorrectOrder=false; // for FoodOrderTurnOff use check

    public virtual void CompareFood(FoodCookImpact FoodCookImpact)
    {
        var FoodOrderData = this.NpcCtrl.NpcOrder.foodData; // FoodOrder
        
        var foodCookpro = FoodCookImpact.FoodCookCtrl.FoodCookPro;

    if (foodCookpro.FoodData == FoodOrderData)
    {
      FoodCookImpact.foodAsOrderd = true;
      
      //  this.isCorrectOrder = true;                                      //OnReceivedFood?.Invoke(); // Notify that food has been received correctly
    }
    }


   
}
