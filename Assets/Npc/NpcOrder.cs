using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;
using Unity.Mathematics;


public class NpcOrder : NpcAbs
{

  [SerializeField] protected int loopCount = 1; // số lần lặp để lấy thức ăn

  //[SerializeField] public FoodData foodData;// nơi lấy data để so sánh

  [SerializeField] public List<FoodData> foodOrders = new List<FoodData>();

   [SerializeField] public Dictionary<FoodData, List<Transform>> foodDataToObjects = new Dictionary<FoodData, List<Transform>>();


  protected override void OnEnable()
  {
    StateOrder.OnStart_Order += GetAmountFoodToOrder;
  }


  public virtual void GetAmountFoodToOrder()
  {
    this.loopCount = UnityEngine.Random.Range(1, 3);

    for (int i = 0; i < this.loopCount; i++)
    {
      var foodCtrl = GameCtrl.Instance.SpawnerFoodOrder.SpanwFood();
      var foodOrderCtrl = foodCtrl.GetComponent<FoodOrderCtrl>();
   //   this.foodData = foodOrderCtrl.FoodOrderPro.FoodData;
      var foodData = foodOrderCtrl.FoodOrderPro.FoodData;

      if (!foodDataToObjects.ContainsKey(foodData))
        foodDataToObjects[foodData] = new List<Transform>();

      foodDataToObjects[foodData].Add(foodCtrl);
      this.foodOrders.Add(foodData);
    }

  }
  protected override void OnDisable()
  {
    StateOrder.OnStart_Order -= GetAmountFoodToOrder;
  }
  
}

