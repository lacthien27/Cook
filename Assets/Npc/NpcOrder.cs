using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;
using Unity.Mathematics;


public class NpcOrder : NpcAbs
{

  [SerializeField] protected int loopCount = 1; // số lần lặp để lấy thức ăn


  [SerializeField] public List<FoodData> foodOrders = new List<FoodData>(); // ko liên quan đến logic , chỉ dùng để qui ước số lượng món ăn

   [SerializeField] public Dictionary<FoodData, List<Transform>> foodDataToObjects = new Dictionary<FoodData, List<Transform>>();


  protected override void OnEnable()
  {
    StateOrder.OnStart_Order += GetAmountFoodToOrder;
  }


  public virtual void GetAmountFoodToOrder()
  {
    this.loopCount = UnityEngine.Random.Range(1, 2);

    for (int i = 0; i < this.loopCount; i++)
    {
      var foodCtrl = GameCtrl.Instance.SpawnerFoodOrder.SpanwFood();
      var foodOrderCtrl = foodCtrl.GetComponent<FoodOrderCtrl>();
      foodOrderCtrl.FollowNpc.FollowTarget(transform);  // gọi hàm theo dõi npc
      var foodData = foodOrderCtrl.FoodOrderPro.FoodData;

      if (!foodDataToObjects.ContainsKey(foodData))
       foodDataToObjects[foodData] = new List<Transform>();// create new list if key does not exist ,has not will throw error

      foodDataToObjects[foodData].Add(foodCtrl); 
      this.foodOrders.Add(foodData);     // ko liên quan đến logic 
    }

  }
  protected override void OnDisable()
  {
    StateOrder.OnStart_Order -= GetAmountFoodToOrder;
  }
  
}

