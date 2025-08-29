using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class SystemCombineDirectory : SystemCombineFoodAbs
{
    [SerializeField] protected List<Transform> listDishsMapping;


    private Dictionary<FoodData, Transform> prefabMap;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadListDish();
        this.LoadDirectoryFood();
    }

    protected virtual void LoadDirectoryFood()
    {
        prefabMap = new Dictionary<FoodData, Transform>();


        foreach (var dish in listDishsMapping)
        {
            var foodMapping = dish.GetComponent<FoodMapping>();
            if (foodMapping.foodData != null && foodMapping.foodTransform != null)
            {
                prefabMap[foodMapping.foodData] = foodMapping.foodTransform;
            }
        }
    }


    protected virtual void LoadListDish() // get from prefabs of SpawnerDish
    {
        this.listDishsMapping.Clear();
        foreach (Transform dish in transform)
        {
            listDishsMapping.Add(dish);
        }

    }

     public Transform GetTransformformDirectory(FoodData key)
    {
        if (prefabMap.TryGetValue(key, out Transform value))
        {
            return value;
        }

        Debug.LogWarning("Không tìm thấy transform cho " + key.name);
        return null;
    }
}



// thử cách  này  tạo 2 list 1 list fooddata 1 list transform
// sau đó 2 list này  sẽ  được  điền  trong  inspector
// sau đó  trong hàm  load directory food  sẽ  dùng 1 vòng for  
// để  điền  các  phần  tử  của 2 list này vào  trong dictionary
// foodmap.Add(listfooddata[i], listtransform[i])
//  cách này  sẽ  giúp  dễ dàng  hơn trong việc  quản lý  các  fooddata và transform
//  và  dễ dàng  hơn trong việc  thêm  bớt  các  fooddata và transform
//  mà  không cần phải  sửa  code



