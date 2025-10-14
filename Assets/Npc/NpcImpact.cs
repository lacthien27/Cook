using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;
using System;


public class NpcImpact : NpcAbs
{
 
  private HashSet<Transform> candidates = new HashSet<Transform>(); // lưu trữ các đối tượng đang trong vùng ảnh hưởng

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.name == "DishImpact")
        {
            var dish = other.transform.parent;
            this.candidates.Add(dish);
           

        }
    }
    protected virtual void OnTriggerStay2D(Collider2D other)
    {


         if (other.transform.name == "DishImpact")
        {
            var dish = other.transform.parent;
            var dishImpact = other.GetComponent<DishImpact>();

             var dishmove = other.transform.parent.GetComponentInChildren<DishMove>();
           dishmove.isCombinedArea = true;       // ko có sẽ lỗi khi kéo thả dish vào npc, dish sẽ bị rơi ra ngoài

             
            if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag && candidates.Contains(dish))
            {
            this.NpcCtrl.NpcReceiveFood.CompareFood(dishImpact);
            this.candidates.Remove(dish);
            }
          }


    }

    protected virtual void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.name == "DishImpact")
        {
            var dish = other.transform.parent;
           var dishmove = other.transform.parent.GetComponentInChildren<DishMove>();
           dishmove.isCombinedArea = false;  
            candidates.Remove(dish);

        }
    }


}