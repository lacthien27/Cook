using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "FoodData", menuName = "SO/FoodData")]

public class FoodData : ScriptableObject
{

    public Sprite icon;
    public float timeCook;

    public float timeBurned;

    public int money;

    public FoodType FoodType; 

    public isStateFood stateFood; // dùng để làm điều kiện lấy trạng thái hay ko 



    

}

public enum FoodType
{
    Egg,
    Rice,
    Meat,
    Vegetable,

    Broken_Rice,

    // thêm các loại khác tùy mày
}


public enum isStateFood
{
    has,
    no,

}

public enum Category
{
    Ingredient,
    Dish,

}





