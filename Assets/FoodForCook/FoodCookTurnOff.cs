using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCookTurnOff : FoodCookAbs
{


    protected void Update()
    {
         this.TurnOff();
    }

    protected virtual void TurnOff()
    {
        if (/**GameCtrl.Instance.MouseCtrl.MousePos.isDrag == false && **/FoodCookCtrl.FoodCookImpact.foodAsOrderd == true)
        {
            GameCtrl.Instance.SpawnerFoodForCook.Despawn(transform.parent);
        }


    }
}
 
