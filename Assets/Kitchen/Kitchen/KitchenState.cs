using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenState : KitchenAbs
{
   public StateOfKitchen currentState = StateOfKitchen.Cold;   // mặc định ban đầu là sống

    public void ChangeState(StateOfKitchen newState)
    {
        if (currentState == newState) return;

        currentState = newState;

        switch (newState)
        {
            case StateOfKitchen.Cold:
                OnCold();
                break;

            case StateOfKitchen.Low:
                OnLow();
                break;

            case StateOfKitchen.Ideal:
                OnIdeal();
                break;

            case StateOfKitchen.High:
                OnHigh();
                break;
        }
    }

    private void OnCold()
    {
      //  Debug.Log($"{name} đang ở trạng thái COLD");
    }

    private void OnLow()
    {
      //  Debug.Log($"{name} bắt đầu COOKING");
        // ví dụ: bật animation, hiệu ứng lửa
    }

    private void OnIdeal()
    {
       // Debug.Log($"{name} đã COOKED");
        // ví dụ: đổi màu, cho phép ăn/serve
    }

    private void OnHigh()
    {
       // Debug.Log($"{name} bị BURNED");
       // // ví dụ: đổi sang màu đen, mất điểm
    }
}


public enum StateOfKitchen
{
    Cold,        // tắt lửa
    Low,            // đang nấu
    Ideal,

    High// hoàn thành
}


