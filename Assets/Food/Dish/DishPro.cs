using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishPro : DishAbs
{
    [SerializeField] private FoodData foodData;
    public FoodData FoodData => foodData;


    [SerializeField]   public Category type; 

}
