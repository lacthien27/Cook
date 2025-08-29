using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemCombineFoodCtrl : GameAbs
{

    [SerializeField] protected SystemArrange systemArrange;
    public SystemArrange SystemArrange => systemArrange;


    [SerializeField] protected SystemCombineFood systemCombineFood;
    public SystemCombineFood SystemCombineFood => systemCombineFood;


    [SerializeField] protected SystemCombineDirectory systemCombineDirectory;
    public SystemCombineDirectory SystemCombineDirectory => systemCombineDirectory;


    [SerializeField] protected SpawnerDish spawnerDish;
    public SpawnerDish SpawnerDish => spawnerDish;



    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSystemArrange();
        this.LoadSystemCombineFood();
        this.LoacSystemCombineDirectory();
        this.LoadSpawnerDish();
    }

    protected virtual void LoacSystemCombineDirectory()
    {
        if (this.systemCombineDirectory != null) return;
        this.systemCombineDirectory = GetComponentInChildren<SystemCombineDirectory>();
        Debug.LogWarning(transform.name + " : Load SystemCombineDirectory", gameObject);
    }


    protected virtual void LoadSystemCombineFood()
    {
        if (this.systemCombineFood != null) return;
        this.systemCombineFood = GetComponentInChildren<SystemCombineFood>();
        Debug.LogWarning(transform.name + " : Load SystemCombineFood", gameObject);
    }

    protected virtual void LoadSystemArrange()
    {
        if (this.systemArrange != null) return;
        this.systemArrange = GetComponentInChildren<SystemArrange>();
        Debug.LogWarning(transform.name + " : Load SystemArrange", gameObject);
    }

    protected virtual void LoadSpawnerDish()
    {
        if (this.spawnerDish != null) return;
        this.spawnerDish = GetComponentInChildren<SpawnerDish>();
        Debug.LogWarning(transform.name + " : Load SpawnerDish", gameObject);
    }

}
