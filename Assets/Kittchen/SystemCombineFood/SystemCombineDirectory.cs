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

        Debug.LogWarning("Không tìm thấy transform cho " + key.name+"vao FoodMapping  coi lại ");  
        
        return null;
    }
}






