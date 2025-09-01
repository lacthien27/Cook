using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FoodCookTurnOff : FoodCookAbs   
{
     public bool isInSysTemCombineFoodArea = false; // check if the food is in the combine area
    protected override void OnEnable()
    {
        // Đăng ký event
        SystemCombineFood.OnEnoughFoodToDish += TurnOff;
    }

   


    public virtual void TurnOff()
    {
         if(this.FoodCookCtrl.FoodCookMove.isCombinedArea==false) return; // only turn off when  in combine area
         // if (this.isInSysTemCombineFoodArea == false) return; // only turn off when  in combine area
       
        Debug.LogWarning("TurnOff called for " + this.name);
        GameCtrl.Instance.SpawnerFoodForCook.Despawn(transform.parent);
        //  this.isInSysTemCombineFoodArea= false; // reset trạng thái sau khi despawn
    }
}
 

