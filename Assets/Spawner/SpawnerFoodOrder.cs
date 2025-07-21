using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Video;


public class SpawnerFoodOrder : Spawner
{


   [SerializeField] public Transform food;
   public static Action OnSpawnedFoodOrder;



   public virtual Transform SpanwFood()
   {
       Transform newPrefab  = this.Spawn(this.RandomPrefab(), GameCtrl.Instance.SpawnerNpc.NpcCurrent.position, Quaternion.identity);
      newPrefab.gameObject.SetActive(true);
      OnSpawnedFoodOrder?.Invoke();
      return newPrefab;
      
    }

  


    

}
