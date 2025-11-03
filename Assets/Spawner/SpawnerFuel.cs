using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFuel : Spawner
{

    [SerializeField] public float timer = 0;

    [SerializeField] private List<Transform> charcoalPrefabs = new List<Transform>();

    protected override void Awake()
    {
        this.SpawnNpc();
    }

    protected void Update()
    {
        if(charcoalPrefabs.Count >= 3) return;
        this.timer += Time.deltaTime;
        if (timer < 2) return;
        this.SpawnNpc();
        charcoalPrefabs.Add(this.SpawnNpc());
        timer = 0;
    }

    protected virtual Transform SpawnNpc()
    {
        var charcoal = this.Spawn(this.RandomPrefab(), new Vector3(3.5f, -4.5f, 0), Quaternion.identity); 
        charcoal.gameObject.SetActive(true);
        return charcoal;
    }
}
