using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemCombineFoodCtrl : GameAbs
{

  //2 object SystemCombineFood phải ko dc trùng nhau vị trí phải cách nhau boa nhiêu cung dc ,

    [SerializeField] protected SystemCombineFood systemCombineFood;
    public SystemCombineFood SystemCombineFood => systemCombineFood;


    [SerializeField] protected SystemCombineDirectory systemCombineDirectory;
    public SystemCombineDirectory SystemCombineDirectory => systemCombineDirectory;

      [SerializeField] protected SystemCombineArrange systemCombineArrange;
    public SystemCombineArrange SystemCombineArrange => systemCombineArrange;




    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSystemCombineArrange();
        this.LoadSystemCombineFood();
        this.LoacSystemCombineDirectory();
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

    protected virtual void LoadSystemCombineArrange()
    {
        if (this.systemCombineArrange != null) return;
        this.systemCombineArrange = GetComponentInChildren<SystemCombineArrange>();
        Debug.LogWarning(transform.name + " : Load SystemCombineArrange", gameObject);
    }


}
