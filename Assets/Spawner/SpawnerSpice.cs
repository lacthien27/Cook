using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSpice : Spawner
{

    public virtual void SpawnSpice(Transform Spice, Vector3 pos)
    {
        var SpiceSpawned = this.Spawn(Spice, pos, Quaternion.identity);
        SpiceSpawned.gameObject.SetActive(true);
    }
}
