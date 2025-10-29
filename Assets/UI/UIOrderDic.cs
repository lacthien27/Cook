using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOrderDic : ThienMonoBehaviour
{
     [Header("Danh sách dữ liệu món ăn (FoodData)")]
    public List<FoodData> foodDataList = new List<FoodData>();

    [Header("Danh sách hình ảnh món ăn (Sprite)")]
    public List<Sprite> foodImageList = new List<Sprite>();

    [HideInInspector]
    public Dictionary<FoodData, Sprite> foodDictionary = new Dictionary<FoodData, Sprite>();

    protected override void OnEnable()
    {
        BuildDictionary();
    }

     public void BuildDictionary()
    {
        foodDictionary.Clear();

        int count = Mathf.Min(foodDataList.Count, foodImageList.Count); // avoid  loop error when  lists lack equal length
        for (int i = 0; i < count; i++)
        {
            if (foodDataList[i] != null && foodImageList[i] != null)
            {
                if (!foodDictionary.ContainsKey(foodDataList[i]))
                {
                    foodDictionary.Add(foodDataList[i], foodImageList[i]);
                }
                else
                {
                    Debug.LogWarning($"Trùng FoodData ở vị trí {i}: {foodDataList[i].name}");
                }
            }
        }
    }

    /// <summary>
    /// Trả về Sprite theo FoodData.
    /// </summary>
    public Sprite GetImage(FoodData foodData)
    {
        if (foodDictionary.TryGetValue(foodData, out Sprite image))
        {
            return image;
        }

        Debug.LogWarning($"Không tìm thấy hình cho {foodData.name}");
        return null;
    }
}

