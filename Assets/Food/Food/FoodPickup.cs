using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPickup : FoodAbs, IsPickupAble
{
    
    [SerializeField]     public  bool isAreaMouse { get; set; }   // is in zone impact off  mouse

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

    public  void OnDrag()
    {
        if (isPickUp == true) return;
                if (isAreaMouse == true && GameCtrl.Instance.MouseCtrl.MousePos.isDrag)
                {
                 this.foodCtrl.FoodMove.Move();
                }
    }

    public void OnDrop()
    {

        if (isAreaMouse == true && !GameCtrl.Instance.MouseCtrl.MousePos.isDrag)
        {
            isPickUp = false;
            this.foodCtrl.FoodMove.ReturnToStartPos();

        }
        

    }
   
}
