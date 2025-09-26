using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishTurnOff : DishAbs
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
            GameCtrl.Instance.SpawnerDish.Despawn(transform.parent);

            this.isCorrectOrder = false; // Reset the order correctness flag
        }

    }
}
