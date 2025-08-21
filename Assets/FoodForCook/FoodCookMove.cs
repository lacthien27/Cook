using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class FoodCookMove : FoodCookAbs
{

   public Vector3 startPos;

   public bool isCombinedArea = false;

   protected override void OnEnable()
   {
      this.startPos = this.transform.parent.position;
   }



   public virtual void Move()
   {
      Vector3 mouseWorldPos = GameCtrl.Instance.MouseCtrl.transform.position;
      this.transform.parent.position = mouseWorldPos;
   }
   
   public virtual void ReturnToStartPos()
   {
      
      if (this.isCombinedArea) return; // true area impact hợp lí thì ko về vị trí ban đầu
      this.transform.parent.position = this.startPos;
      
   }


 
}
