using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCookPro : FoodCookAbs
{
    [SerializeField] private FoodData foodData;
    public FoodData FoodData => foodData;


    [SerializeField]   public Separate type; 

}



