using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class FoodCookMove : FoodCookAbs
{

   public Vector2 cellSize = new Vector2(0f, 0f);

   public Vector3 startPos;

   public bool isCombinedArea = false;

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
      if(this.isCombinedArea) return;

      //condition to check if the mouse is not dragging and the currentObject is this foodCookCtrl's FoodCookImpact
      if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag && MouseImpact.currentObject == this.foodCookCtrl.FoodCookImpact)
      {
           this.transform.parent.position = this.startPos;
      }
   }


 
}
