using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTimer : FoodAbs
{
     public float cookTime = 5f;     // thời gian để nấu chín
    public float burnTime = 8f;     // thời gian để cháy (sau khi chín)

    private bool isOnBarGrill = false; 

  [SerializeField]  private float timer=0f;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.cookTime = this.FoodCtrl.FoodPro.FoodData.timeCook;
        this.burnTime= this.FoodCtrl.FoodPro.FoodData.timeBurned;

    }

    protected virtual void Update()
    {

        if (isOnBarGrill && this.FoodCtrl.FoodState.currentState == StateOfFood.Cooking)
        {
            timer += Time.deltaTime;
            if (timer >= cookTime)
            {
                this.FoodCtrl.FoodState.ChangeState(StateOfFood.Cooked);
                Debug.LogWarning("cook finish" + transform.parent.name);
            }
            
        }

        if (isOnBarGrill && this.FoodCtrl.FoodState.currentState == StateOfFood.Cooked)
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

        isOnBarGrill = true;
        }
        

    }

    // gọi hàm này khi nhấc khỏi bếp
    public void StopCooking()
    {                       isOnBarGrill = false;


    }
}
