using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFoodForCook : Spawner
{


    protected override void Start()
    {
        this.SpawnFoodCook();
        // StartCoroutine(SpawnFoodCookLoop());
       InvokeRepeating(nameof(SpawnFoodCook), 5f, 70f);

    }

    public virtual void SpawnFoodCook()
    {
        var foodForCook = this.Spawn(this.RandomPrefab(), GameCtrl.Instance.KitChenCabinet.transform.position, Quaternion.identity);
        foodForCook.gameObject.SetActive(true);
    }
    

    
}
