using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateFood : FoodCookAbs
{
   public FoodState currentState = FoodState.Raw;   // mặc định ban đầu là sống

    public void ChangeState(FoodState newState)
    {
        if (currentState == newState) return;

        currentState = newState;

        switch (newState)
        {
            case FoodState.Raw:
                OnRaw();
                break;

            case FoodState.Cooking:
                OnCooking();
                break;

            case FoodState.Cooked:
                OnCooked();
                break;

            case FoodState.Burned:
                OnBurned();
                break;
        }
    }

    private void OnRaw()
    {
        Debug.Log($"{name} đang ở trạng thái RAW");
    }

    private void OnCooking()
    {
        Debug.Log($"{name} bắt đầu COOKING");
        // ví dụ: bật animation, hiệu ứng lửa
    }

    private void OnCooked()
    {
        Debug.Log($"{name} đã COOKED");
        // ví dụ: đổi màu, cho phép ăn/serve
    }

    private void OnBurned()
    {
        Debug.Log($"{name} bị BURNED");
        // ví dụ: đổi sang màu đen, mất điểm
    }
}


public enum FoodState
{
    Raw,        // sống
    Cooking,    // đang nấu
    Cooked,     // chín hoàn hảo
    Burned      // cháy
}