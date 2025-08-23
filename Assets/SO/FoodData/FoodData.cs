using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "FoodData", menuName = "SO/FoodData")]

public class FoodData : ScriptableObject
{

    public Sprite icon;
    public float timeCook;

    public int money;

    public FoodType type; // đổi từ string -> enum

}

public enum FoodType
{
    Egg,
    Rice,
    Meat,
    Vegetable,
    
    // thêm các loại khác tùy mày
}


