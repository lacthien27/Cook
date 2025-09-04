using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageIgdPro : StorageIgdAbs
{
     [SerializeField] private FoodData foodData;
    public FoodData FoodData => foodData;


    [SerializeField]   public Category CookingCategory; 
}
