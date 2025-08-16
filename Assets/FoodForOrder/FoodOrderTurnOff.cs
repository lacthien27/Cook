using System.Collections;
using System.Collections.Generic;
using Mono.Cecil.Cil;
using UnityEngine;

public class FoodOrderTurnOff : FoodOrderAbs
{
    [SerializeField] public bool isCorrectOrder=false; // for NpcReceiveFood use check

     protected void Update()
    {
        
        this.TurnOff();
    }

    public virtual void TurnOff()

    {
        if (GameCtrl.Instance.MouseCtrl.MousePos.isDrag == false && isCorrectOrder == true )
        {
            GameCtrl.Instance.SpawnerFoodOrder.Despawn(transform.parent);

            this.isCorrectOrder = false; // Reset the order correctness flag
        }

    }
}
