using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerDish : Spawner
{
     public virtual void SpawnDish(Transform prefab)
    {
        var dish = this.Spawn(prefab.transform,transform.parent.position, Quaternion.identity);
        dish.gameObject.SetActive(true);
    }
}
