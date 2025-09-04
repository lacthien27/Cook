using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class SpawnerFoodForCook : Spawner
{
    [SerializeField] protected List<Transform> Listdishs = new List<Transform>();

    [SerializeField] protected List<Transform> ListIngredients = new List<Transform>();

    //public static event Action OnSpawnFoodForCook;



    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.SeparateObj();    // always separate obj first before spawn

    }

    protected override void Start()
    {
        this.SpawnFoodCook();
        InvokeRepeating(nameof(SpawnFoodCook), 3f, 3f);

    }

    public virtual void SpawnFoodCook()
    {
        //  var foodForCook = this.Spawn(this.RandomIngredient(), GameCtrl.Instance.KitChenCabinet.transform.position, Quaternion.identity);
        //var foodForCook = this.Spawn(this.RandomIngredient(), this.FindParrent(RandomIngredient()).position, Quaternion.identity);
        // Debug.LogWarning(this.FindParrent(RandomIngredient()).transform.name);
        //foodForCook.gameObject.SetActive(true);

        var foodForCook = this.Spawn(this.RandomIngredient(), transform.parent.position, Quaternion.identity);
        //Debug.LogWarning(this.FindParrent(RandomIngredient()).transform.name);'
        foodForCook.transform.position= this.FindParrent(foodForCook).position;
        foodForCook.gameObject.SetActive(true);



    }
    

    public virtual void SpawnDish(Transform dish, Vector3 pos)
    {
        var dishSpawned = this.Spawn(dish, pos, Quaternion.identity);
        dishSpawned.gameObject.SetActive(true);
    }

    public virtual Transform RandomIngredient()
    {
        int rand = UnityEngine.Random.Range(0, this.ListIngredients.Count);
        return this.ListIngredients[rand];


    }


    public virtual Transform FindParrent(Transform obj)
    {
        var objCtrl = obj.GetComponent<FoodCookCtrl>();
        var objPro = objCtrl.FoodCookPro.FoodData.FoodType;
        Debug.Log("Input FoodType: " + objPro.ToString()); // Log type của input mỗi lần

        foreach (Transform Storage in GameCtrl.Instance.StorageIngredients)
        {
            var StorageCtrl = Storage.transform.GetComponent<StorageIgdCtrl>();
            var StoragePro = StorageCtrl.StorageIgdPro.FoodData.FoodType;
            Debug.Log("Checking Storage: " + Storage.name + " with type: " + StoragePro.ToString()); // Log từng Storage

            if (objPro == StoragePro)
            {
                // obj.transform.position = Storage.transform.position;
                return Storage; // Trả về Transform của Storage phù hợp                
            }
        }
    return null;
}



    protected virtual void SeparateObj()
    {
        this.Listdishs.Clear();
        this.ListIngredients.Clear();
        foreach (var item in this.prefabs)
        {
            var FoodCtrl = item.GetComponent<FoodCookCtrl>();
            var FoodPro = FoodCtrl.FoodCookPro;
            if (FoodPro.type == Category.Dish)
            {
                this.Listdishs.Add(item.transform);
            }
            else 
            {
                this.ListIngredients.Add(item.transform);
            }
        }

    }
}
