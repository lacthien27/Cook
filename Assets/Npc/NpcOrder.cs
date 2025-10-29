using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;
using Unity.Mathematics;


public class NpcOrder : NpcAbs
{

  [SerializeField] protected int loopCount = 1; // số lần lặp để lấy thức ăn


 // [SerializeField] public List<FoodData> foodOrders = new List<FoodData>(); // ko liên quan đến logic , chỉ dùng để qui ước số lượng món ăn

   [SerializeField] public Dictionary<FoodData, List<Transform>> foodDataToObjects = new Dictionary<FoodData, List<Transform>>();// dùng để lưu trữ món ăn và đối tượng tương ứng


  protected override void OnEnable()
  {
    this.NpcCtrl.StateMachineCtrl.StateOrder.OnStart_Order += GetAmountFoodToOrder;
  }


  public virtual void GetAmountFoodToOrder()
  {
    this.loopCount = UnityEngine.Random.Range(0, 2);

    for (int i = 0; i <= this.loopCount; i++)
    {
      var foodCtrl = GameCtrl.Instance.SpawnerFoodOrder.SpanwFood();
      var foodOrderCtrl = foodCtrl.GetComponent<FoodOrderCtrl>();
       foodOrderCtrl.FollowNpc.FollowTarget(this.NpcCtrl.NpcCheckOrders.transform,i);  // gọi hàm theo dõi npc , get position of npcOrder not npcCtrl
      var foodData = foodOrderCtrl.FoodOrderPro.FoodData;

     if (!foodDataToObjects.ContainsKey(foodData))
       foodDataToObjects[foodData] = new List<Transform>();
     foodDataToObjects[foodData].Add(foodCtrl);

    // this.foodOrders.Add(foodData);     // ko liên quan đến logic
     }
     

  }
  protected override void OnDisable()
  {
   this.NpcCtrl.StateMachineCtrl.StateOrder.OnStart_Order -= GetAmountFoodToOrder;
  }
  
}

