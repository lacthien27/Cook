using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Video;


public class SpawnerNpc : Spawner
{
    [SerializeField] public Transform NpcCurrent;

    [SerializeField] public float timer = 0;


    public static Action OnSpawnNpc; // event thông báo cho MinoCtrl

    protected override void Awake()
    {
        this.SpawnNpc();
    }

    protected void Update()
    {
        if (GameCtrl.Instance.ArrangeNpc.IsFull()) return;
        this.timer += Time.deltaTime;
        if (timer < 3) return;
        this.SpawnNpc();
        timer = 0;
    }

    protected virtual void SpawnNpc()
    {
        this.NpcCurrent = this.Spawn(this.RandomPrefab(), new Vector3(-6, 10, 0), Quaternion.identity); 
        this.NpcCurrent.gameObject.SetActive(true);
        OnSpawnNpc?.Invoke(); // gọi sự kiện khi NPC được spawn
    }
    

    




}
