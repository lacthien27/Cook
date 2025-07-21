using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFoodForCook : Spawner
{


    protected override void Start()
    {
        this.SpawnFoodCook();
      //  StartCoroutine(SpawnFoodCookLoop());

    }

    protected virtual void SpawnFoodCook()
    {
        var foodForCook = this.Spawn(this.RandomPrefab(), GameCtrl.Instance.KitChenCabinet.transform.position, Quaternion.identity);
        foodForCook.gameObject.SetActive(true);
    }
    
    private IEnumerator SpawnFoodCookLoop()
{
    while (true)
    {
        SpawnFoodCook();
        yield return new WaitForSeconds(5f);
    }
}
    
}
