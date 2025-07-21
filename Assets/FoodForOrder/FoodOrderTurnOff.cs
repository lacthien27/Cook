using System.Collections;
using System.Collections.Generic;
using Mono.Cecil.Cil;
using UnityEngine;

public class FoodOrderTurnOff : FoodOrderAbs
{
    protected virtual void Update()
    {
       // this.TurnOff();
    }
  

    public virtual void TurnOff()
    
    {
        var npcCtrl = this.FoodOrderCtrl.FollowNpc.Npctarget.GetComponent<NpcCtrl>();
        var NpcReceiveFood= npcCtrl.NpcReceiveFood;
    
        if (/**NpcReceiveFood.isCorrectOrder && **/ GameCtrl.Instance.MouseCtrl.MousePos.isDrag == false)
        {
            Debug.LogWarning("f");

            GameCtrl.Instance.SpawnerFoodOrder.Despawn(transform.parent);
           // NpcReceiveFood.isCorrectOrder = false; // Reset the order correctness flag
        }
      




    }
}
