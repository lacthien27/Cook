using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class FoodCookMove : FoodCookAbs
{

   public Vector3 startPos;

   protected override void OnEnable()
   {
      this.startPos = this.transform.parent.position;
   }

   protected virtual void Update()
   {

      this.Drag();
       this.ReturnToStartPos();
      
   }

   protected virtual void Drag()
   {

      //codition to check if the mouse is dragging and the currentObject is this foodCookCtrl's FoodCookImpact
      if (GameCtrl.Instance.MouseCtrl.MousePos.isDrag && MouseImpact.currentObject == this.foodCookCtrl.FoodCookImpact)
      {

         Vector3 mouseWorldPos = GameCtrl.Instance.MouseCtrl.transform.position;
         this.transform.parent.position = mouseWorldPos;
      }

   }
   
   protected virtual void ReturnToStartPos()
   {
      //condition to check if the mouse is not dragging and the currentObject is this foodCookCtrl's FoodCookImpact
      if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag && MouseImpact.currentObject == this.foodCookCtrl.FoodCookImpact)
      {
         this.transform.parent.position = this.startPos; //Vector3.Lerp(this.transform.parent.position, this.startPos, 0.1f);
      }
   }


 
}
