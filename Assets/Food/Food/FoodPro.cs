using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPro : FoodAbs
{
    [SerializeField] private FoodData foodData;
    public FoodData FoodData => foodData;


    [SerializeField]   public Category type; 

}



