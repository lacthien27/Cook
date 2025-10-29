using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq; // nhớ thêm dòng này ở trên
using System;



public class SystemCombineFood : SystemCombineFoodAbs
{
  [SerializeField] public List<RecipeSO> recipes;   // list of recipes for mixing
  [SerializeField] public List<FoodData> currentFoods = new List<FoodData>();  // list of current foods for mixing

  public static event Action OnEnoughFoodToDish;


  public void GetListFoodData() // get Data from Transform list in SystemArrange
  {
    currentFoods.Clear(); // Xóa list cũ trước khi build lại
    foreach (var obj in this.SystemCombineFoodCtrl.SystemCombineArrange.listDish)
    {

      if (obj.transform.GetComponent<DishCtrl>() != null) return;  // place in here will ko add dish in list CurrentFood , 
      var foodCtrl = obj.GetComponent<FoodCtrl>();
      FoodData foodData = foodCtrl.FoodPro.FoodData;
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
        //   GameCtrl.Instance.SpawnerFoodForCook.SpawnDish(DishData,transform.parent.position);
        GameCtrl.Instance.SpawnerDish.SpawnDish(DishData, transform.parent.position);
        this.OnlyGetObjBelongOWner(); // only set true for object belong to this SystemCombineFood
        OnEnoughFoodToDish?.Invoke(); // gọi event (nếu có người lắng nghe)

        ClearIngredients();  // leave it at last
        break;
      }
    }
  }

  bool MatchRecipe(RecipeSO recipe)
  {
    var need = recipe.inputFoods
        .GroupBy(x => x.FoodType)
        .ToDictionary(g => g.Key, g => g.Count());

    var have = this.currentFoods
        .GroupBy(x => x.FoodType)
        .ToDictionary(g => g.Key, g => g.Count());

    if (need.Count != have.Count) return false;

    foreach (var kv in need)
    {
      if (!have.TryGetValue(kv.Key, out var count) || count != kv.Value)
        return false;
    }

    return true;
  }


  void ClearIngredients()
  {

    this.SystemCombineFoodCtrl.SystemCombineArrange.listDish.Clear(); //list Transform
    currentFoods.Clear();

  }


  protected virtual void OnlyGetObjBelongOWner()  //  chỉ lấy các object thuộc cùng 1 SystemCombineFood 
  {
    foreach (var obj in this.SystemCombineFoodCtrl.SystemCombineArrange.listDish) // dùng ToList() để tránh lỗi khi xóa phần tử trong vòng lặp
    {
      var objCtrl = obj.GetComponent<FoodCtrl>();
      objCtrl.FoodTurnOff.isInSysTemCombineFoodArea = true; // set true cho các object trong vùng va chạm
    }
  }

}