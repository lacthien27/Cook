using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class SpawnerIngredient : Spawner
{

   // [SerializeField] protected List<Transform> ListIngredients = new List<Transform>();


    protected override void LoadComponents()
    {
        base.LoadComponents();

    }

    protected override void Start()
    {
        this.SpawnFoodCook();
        InvokeRepeating(nameof(SpawnFoodCook), 1f, 5f);

    }

    public virtual void SpawnFoodCook()
    {
        var foodForCook = this.Spawn(this.RandomPrefab(), transform.parent.position, Quaternion.identity);
        foodForCook.transform.position= this.FindParrent(foodForCook).position;
        foodForCook.gameObject.SetActive(true);
    }
    /**
    public virtual Transform RandomIngredient()
    {
        int rand = UnityEngine.Random.Range(0, this.ListIngredients.Count);
        return this.ListIngredients[rand];
    }**/

    public virtual Transform FindParrent(Transform obj)
    {
        var objCtrl = obj.GetComponent<FoodCtrl>();
        var objPro = objCtrl.FoodPro.FoodData.FoodType;

        foreach (Transform Storage in GameCtrl.Instance.StorageIngredients)
        {
            var StorageCtrl = Storage.transform.GetComponent<StorageIgdCtrl>();
            var StoragePro = StorageCtrl.StorageIgdPro.FoodData.FoodType;

            if (objPro == StoragePro)
            {
                return Storage; // Trả về Transform của Storage phù hợp                
            }
        }
    return null;
}



  /**  protected virtual void SeparateObj()
    {
        this.Listdishs.Clear();
        this.ListIngredients.Clear();
        this.Listspices.Clear();
        foreach (var item in this.prefabs)
        {
            var FoodCtrl = item.GetComponent<FoodCookCtrl>();
            var FoodPro = FoodCtrl.FoodCookPro;
            if (FoodPro.type == Category.Dish)    // nên sài swtich
            {
                this.Listdishs.Add(item.transform);
            }
            else if (FoodPro.type == Category.Ingredient)
            {
                this.ListIngredients.Add(item.transform);
            }
            else
            {
                this.Listspices.Add(item.transform);
            }
        }

    }**/
}
