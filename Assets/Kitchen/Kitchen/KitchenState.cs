using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenState : KitchenAbs
{
   /** [Header("🔥 Timer Settings")]
    [SerializeField] private float maxTime = 100f;   // thời gian cháy tối đa khi đầy
    [SerializeField] private float countdown;       // thời gian còn lại

    [Header("🪵 Charcoal Settings")]
    [SerializeField] private float charcoalAddTime = 20f; // +2s mỗi charcoal


    public StateOfKitchen currentState = StateOfKitchen.Cold;   // mặc định ban đầu là sống

    protected override void Start()
    {
        countdown = 100f;
        ChangeState(StateOfKitchen.Ideal);
    }

    private void FixedUpdate()
    {
        if (currentState == StateOfKitchen.Cold) return;

        countdown -= Time.deltaTime;
        countdown = Mathf.Max(countdown, 0f); 

        // 🧠 Xác định trạng thái mới bằng switch expression
        StateOfKitchen newState = countdown switch
        {
            <= 0f => StateOfKitchen.Cold,
            <= 20f => StateOfKitchen.Low,
            <= 80f => StateOfKitchen.Ideal,
            _ => StateOfKitchen.High
        };

        ChangeState(newState); 
    }

    public void AddCharcoal()
    {
        float addedTime = charcoalAddTime;
        countdown += addedTime;

        if (countdown > maxTime)
            countdown = maxTime;

    }**/

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
        Debug.Log($"{name} đang ở trạng thái COLD");
    }

    private void OnLow()
    {
    //  Debug.Log($"{name} bắt đầu COOKING");
        // ví dụ: bật animation, hiệu ứng lửa
    }

    private void OnIdeal()
    {
  //      Debug.Log($"{name} đã COOKED");
        // ví dụ: đổi màu, cho phép ăn/serve
    }

    private void OnHigh()
    {
//        Debug.Log($"{name} bị BURNED");
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


