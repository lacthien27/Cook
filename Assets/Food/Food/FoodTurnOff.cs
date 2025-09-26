using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FoodTurnOff : FoodAbs
{
    public bool isInSysTemCombineFoodArea = false; // check if the food is in the combine area
    protected override void OnEnable()
    {
        // Đăng ký event
        SystemCombineFood.OnEnoughFoodToDish += TurnOffWhenCombine;
    }

    public virtual void TurnOffWhenCombine()
    {
        if (this.isInSysTemCombineFoodArea == false) return; // only turn off when  in combine area
        GameCtrl.Instance.SpawnerIngredient.Despawn(transform.parent);

        this.isInSysTemCombineFoodArea = false; // reset trạng thái sau khi despawn
    }


    public virtual void TurnOffWhenCook()
    {
        GameCtrl.Instance.SpawnerIngredient.Despawn(transform.parent);

    }


}
 

