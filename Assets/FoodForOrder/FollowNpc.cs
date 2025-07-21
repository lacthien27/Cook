using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FollowNpc : FoodOrderAbs


{

    [SerializeField] public Transform Npctarget;
    protected override void OnEnable()
    {
        SpawnerFoodOrder.OnSpawnedFoodOrder += FollowTarget;
    }


    protected virtual void FollowTarget()
    {
        this.Npctarget = GameCtrl.Instance.SpawnerNpc.NpcCurrent;
        var npcCtrl = Npctarget.GetComponent<NpcCtrl>();
        var npcOrder = npcCtrl.NpcOrder;
        transform.parent.position = npcOrder.transform.position;
    }
    
    protected override void OnDisable()
    {
        SpawnerFoodOrder.OnSpawnedFoodOrder -= FollowTarget;
    }
}
