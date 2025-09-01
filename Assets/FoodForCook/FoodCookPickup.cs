using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCookPickup : FoodCookAbs, IsPickupAble
{
    
    [SerializeField]     public  bool isAreaImpact { get; set; }   // is in zone impact off  mouse

    [SerializeField]    public bool isPickUp{ get; set; }  //  picked up  will do not allow to move object otherwise
        
         protected override void OnEnable()
    {
        isPickUp= false;
    }

        protected virtual void Update()
    {

        this.OnDrag();
        this.OnDrop();

    }
 
    public void OnDrag()
    {
        if (isPickUp == true) return;
                if (isAreaImpact == true && GameCtrl.Instance.MouseCtrl.MousePos.isDrag)
                {
                    this.foodCookCtrl.FoodCookMove.Move();
                }
    }

    public void OnDrop()
    {

        if (isAreaImpact == true && !GameCtrl.Instance.MouseCtrl.MousePos.isDrag)
        {
            isPickUp = false;
            this.foodCookCtrl.FoodCookMove.ReturnToStartPos();

        }
        

    }
   
}
