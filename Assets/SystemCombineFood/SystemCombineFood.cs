using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq; // nhớ thêm dòng này ở trên


public class SystemCombineFood : SystemCombineFoodAbs
{
    [SerializeField]   public List<RecipeSO> recipes;   // list of recipes for mixing
  [SerializeField]  public List<FoodData> currentFoods = new List<FoodData>();  // list of current foods for mixing



  public void GetListFoodData()
    {
      currentFoods.Clear(); // Xóa list cũ trước khi build lại
      foreach (var obj in this.SystemCombineFoodCtrl.SystemArrange.listDish)
      {
        var foodCtrl = obj.GetComponent<FoodCookCtrl>();
        FoodData foodData = foodCtrl.FoodCookPro.FoodData;
        currentFoods.Add(foodData);
      }
      this.CheckRecipe();

    }

    
  

    void CheckRecipe()
    {
      foreach (var recipe in recipes)
      {
        if (MatchRecipe(recipe))
        {
        Transform DishData = this.SystemCombineFoodCtrl.SystemCombineDirectory.GetTransformformDirectory(recipe.ResultDish);
        Debug.Log("Matched Recipe: " + recipe.name);
       this.SystemCombineFoodCtrl.SpawnerDish.SpawnDish(DishData);
        ClearInputs();  // delete input foods after successful recipe
          break;
        }
      }
    }

    bool MatchRecipe(RecipeSO recipe)
{
    var need = recipe.inputFoods
        .GroupBy(x => x.type)
        .ToDictionary(g => g.Key, g => g.Count());

    var have = this.currentFoods
        .GroupBy(x => x.type)
        .ToDictionary(g => g.Key, g => g.Count());

    if (need.Count != have.Count) return false;

    foreach (var kv in need)
    {
        if (!have.TryGetValue(kv.Key, out var count) || count != kv.Value)
            return false;
    }

    return true;
}


    void ClearInputs()
    {
      // Xóa hết món input (destroy object ngoài scene)
      // clear list
      currentFoods.Clear();
    }

  


}