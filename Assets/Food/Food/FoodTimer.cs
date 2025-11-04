using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTimer : FoodAbs
{
     public float cookTime = 0f;     // thời gian để nấu chín
    public float burnTime = 0f;     // thời gian để cháy (sau khi chín)

    public bool isOnBar = false; 

  [SerializeField]  private float timer=0f;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.cookTime = this.FoodCtrl.FoodPro.FoodData.timeCook;
        this.burnTime= this.FoodCtrl.FoodPro.FoodData.timeBurned;

    }

    protected virtual void FixedUpdate()
    {

        if (isOnBar && this.FoodCtrl.FoodState.currentState == StateOfFood.Cooking)
        {
            Debug.LogWarning(timer);
            timer += Time.deltaTime;
            if (timer >= cookTime)
            {
                this.FoodCtrl.FoodState.ChangeState(StateOfFood.Cooked);
                Debug.LogWarning("cook finish" + transform.parent.name);
            }

        }

        if (isOnBar && this.FoodCtrl.FoodState.currentState == StateOfFood.Cooked)
        {
            timer += Time.deltaTime;

            if (timer >= burnTime)
            {
                this.FoodCtrl.FoodState.ChangeState(StateOfFood.Burned);
                Debug.LogWarning("cook burned" + transform.parent.name);

            }
        }


    }

    // gọi hàm này khi đặt lên bếp
    public void StartCooking()
    {
        if (this.FoodCtrl.FoodState.currentState == StateOfFood.Raw)
        {
            this.FoodCtrl.FoodState.ChangeState(StateOfFood.Cooking);
            isOnBar = true;
        }

    }

    public void StartCookingAgain()
    {
        if (this.FoodCtrl.FoodState.currentState == StateOfFood.Burned) return;
        isOnBar = true;

    }

    // gọi hàm này khi nhấc khỏi bếp
    public void StopCooking()
    {               
        isOnBar = false;

    }
}
