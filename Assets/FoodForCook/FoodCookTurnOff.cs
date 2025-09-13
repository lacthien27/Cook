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
        SystemCombineFood.OnEnoughFoodToDish += TurnOffWhenCombine;
    }

    public virtual void TurnOffWhenCombine()
    {
        if (this.isInSysTemCombineFoodArea == false) return; // only turn off when  in combine area
        GameCtrl.Instance.SpawnerFoodForCook.Despawn(transform.parent);
        this.isInSysTemCombineFoodArea = false; // reset trạng thái sau khi despawn
    }


    public virtual void TurnOffWhenCook()
    {
        GameCtrl.Instance.SpawnerFoodForCook.Despawn(transform.parent);

    }


}
 

