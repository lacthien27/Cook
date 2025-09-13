using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCookTimer : FoodCookAbs
{
     public float cookTime = 5f;     // thời gian để nấu chín
    public float burnTime = 8f;     // thời gian để cháy (sau khi chín)

    private bool isOnBarGrill = false; 

  [SerializeField]  private float timer=0f;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.cookTime = this.FoodCookCtrl.FoodCookPro.FoodData.timeCook;
        this.burnTime= this.FoodCookCtrl.FoodCookPro.FoodData.timeBurned;

    }

    protected virtual void Update()
    {

        if (isOnBarGrill && this.FoodCookCtrl.StateFood.currentState == FoodState.Cooking)
        {
            timer += Time.deltaTime;

            if (timer >= cookTime)
            {
                this.FoodCookCtrl.StateFood.ChangeState(FoodState.Cooked);
            }
            
        }

        if (isOnBarGrill && this.FoodCookCtrl.StateFood.currentState == FoodState.Cooked)
        {
            timer += Time.deltaTime;

            if (timer >= burnTime)
            {
                this.FoodCookCtrl.StateFood.ChangeState(FoodState.Burned);

            }
        }
        


    }

    // gọi hàm này khi đặt lên bếp
    public void StartCooking()
    {
        // timer = 0f;
        this.FoodCookCtrl.StateFood.ChangeState(FoodState.Cooking);

        isOnBarGrill = true;

    }

    // gọi hàm này khi nhấc khỏi bếp
    public void StopCooking()
    {
        // timer = 0f;
                       isOnBarGrill = false;


    }
}
