using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RecipeSO", menuName = "SO/RecipeSO")]

public class RecipeSO : ScriptableObject
{
  public List<FoodData> inputFoods;
  public int money;
  public FoodData ResultDish;


  //public Transform outputPrefab;


  // phải có trạng thái các món ăn đưa vào để kết quả là món ăn bình thường hay bị khét ,bị chưa chín   
  //state sẽ nằm trong foodCtrl  
  //khi so sánh lấy foodCtrl.state + foodData.type để so sánh 
  //ResultDish sẽ được nạp vào spawn




}
