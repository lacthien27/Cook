using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFoodForCook : Spawner
{
    [SerializeField] protected List<Transform> Listdishs = new List<Transform>();

    [SerializeField] protected List<Transform> ListIngredients = new List<Transform>();

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.SeparateObj();    // always separate obj first before spawn

    }

    protected override void Start()
    {
        this.SpawnFoodCook();
        InvokeRepeating(nameof(SpawnFoodCook), 2f, 2f);

    }

    public virtual void SpawnFoodCook()
    {
        var foodForCook = this.Spawn(this.RandomIngredient(), GameCtrl.Instance.KitChenCabinet.transform.position, Quaternion.identity);
        foodForCook.gameObject.SetActive(true);
    }
    

    public virtual void SpawnDish(Transform dish, Vector3 pos)
    {
        var dishSpawned = this.Spawn(dish, pos, Quaternion.identity);
        dishSpawned.gameObject.SetActive(true);
    }

    public virtual Transform RandomIngredient()
    {
        int rand = Random.Range(0, this.ListIngredients.Count);
        return this.ListIngredients[rand];

    }


    protected virtual void SeparateObj()
    {
        this.Listdishs.Clear();
        this.ListIngredients.Clear();
        foreach (var item in this.prefabs)
        {
            var FoodCtrl = item.GetComponent<FoodCookCtrl>();
            var FoodPro = FoodCtrl.FoodCookPro;
            if (FoodPro.type == Separate.Dish)
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
