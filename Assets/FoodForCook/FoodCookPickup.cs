using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCookPickup : FoodCookAbs,IsPickupAble
{

     public  bool isPickup { get; set; }

       public bool isCombinedArea = false;

    protected virtual void Update()
    {

        this.OnDrag();
        this.OnDrop();

    }
    public void OnPickup()
    {

    }

    public void OnDrag()
    {
        if (MouseImpact.currentObject != null) return;
            if (isPickup == true && GameCtrl.Instance.MouseCtrl.MousePos.isDrag)
            {
                this.foodCookCtrl.FoodCookMove.Move();
                Debug.LogWarning("g");
            }
        
        
    }

    public void OnDrop()
    {

      if (isPickup == true && !GameCtrl.Instance.MouseCtrl.MousePos.isDrag)
        {

            this.foodCookCtrl.FoodCookMove.ReturnToStartPos();
        }
    }

}
