using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTableWare : Spawner
{


    virtual public void SpawnPlate(Vector3 posSpawn)
    {
        Transform ricePrefab = prefabs[0];
        var rice = this.Spawn(ricePrefab,posSpawn, Quaternion.identity);
        rice.gameObject.SetActive(true);
    }
}
