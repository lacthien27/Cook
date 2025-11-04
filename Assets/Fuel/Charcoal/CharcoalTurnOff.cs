using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcoalTurnOff : CharcoalAbs
{
 public virtual void TurnOff()

    {
        GameCtrl.Instance.SpawnerFuel.Despawn(transform.parent);
    }  
}
