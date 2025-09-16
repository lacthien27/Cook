using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerDish : Spawner
{
  
    public virtual void SpawnDish(Transform dish, Vector3 pos)
    {
        var dishSpawned = this.Spawn(dish, pos, Quaternion.identity);
        dishSpawned.gameObject.SetActive(true);
    }
}
