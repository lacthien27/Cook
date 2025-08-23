using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RecipeSO", menuName = "SO/RecipeSO")]

public class RecipeSO : ScriptableObject
{
  public List<FoodData> inputFoods;
  public int money;

  public Transform outputPrefab;



}
