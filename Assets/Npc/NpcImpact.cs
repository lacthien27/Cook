using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;
using System;


public class NpcImpact : NpcAbs
{
  //[SerializeField] public bool mouseOnNpc= false;
  /**
    private HashSet<Transform> candidates = new HashSet<Transform>(); // lưu trữ các đối tượng đang trong vùng ảnh hưởng


    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
      if (other.transform.name == "DishImpact")
      {
       // Debug.LogWarning("Enter NpcImpact");
        var obj = other.transform.parent;
        this.candidates.Add(obj);


      }


    }

    protected virtual void OnTriggerStay2D(Collider2D other)
    {
      if (other.transform.name == "DishImpact")
      {
        var obj = other.transform.parent;
        var dishImpact = other.GetComponent<DishImpact>();
        Debug.LogWarning("Stay NpcImpact");
        Debug.LogWarning(this.candidates.Count);
        Debug.LogWarning("isDrag value: " + GameCtrl.Instance.MouseCtrl.MousePos.isDrag);
       
      
        if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag && candidates.Contains(obj))
        {
          this.NpcCtrl.NpcReceiveFood.CompareFood(dishImpact);
          this.candidates.Remove(obj);

        }
      }

      

    }



    protected virtual void OnTriggerExit2D(Collider2D other)
    {
      if (other.transform.name == "DishImpact")
      {
        var obj = other.transform.parent;
        this.candidates.Remove(obj);
       // Debug.LogWarning("Exit NpcImpact");

      }


    }
  **/


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
           
            candidates.Remove(dish);

        }
    }


}