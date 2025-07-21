using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;


public class NpcOrder : NpcAbs
{

  [SerializeField] protected int loopCount = 1; // số lần lặp để lấy thức ăn

  [SerializeField] public FoodData foodData;// nơi lấy data để so sánh

  [SerializeField] protected List<FoodData> foodOrders = new List<FoodData>();


public static Action OnSpawnedFood;

  protected override void OnEnable()
  {
    StateOrder.OnComplete_Order += GetFoodToOrder;
  }


  public virtual void GetFoodToOrder()
  {
     this.loopCount = UnityEngine.Random.Range(1, 4);

    for (int i = 0; i < this.loopCount; i++)
    {
      Debug.Log("f");
      var foodCtrl = GameCtrl.Instance.SpawnerFoodOrder.SpanwFood();
      var foodOrderCtrl = foodCtrl.GetComponent<FoodOrderCtrl>();
      this.foodData = foodOrderCtrl.FoodOrderPro.FoodData;
      this.foodOrders.Add(foodData);
      // OnSpawnedFood?.Invoke();


    }

  }
  protected override void OnDisable()
  {
    StateOrder.OnComplete_Order -= GetFoodToOrder;
  }
}

