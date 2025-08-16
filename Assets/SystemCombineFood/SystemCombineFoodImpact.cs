using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemCombineFoodImpact : SystemCombineFoodAbs
{
   [SerializeField] public List<Transform> listFood = new List<Transform>(); // Dùng List thay vì mảng

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.name == "Impact")
        {
            var cookmove = other.transform.parent.GetComponentInChildren<FoodCookMove>();
            if (GameCtrl.Instance.MouseCtrl.MousePos.isDrag) return;
            listFood.Add(other.transform.parent);


        }

    }
    


    protected virtual void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.name == "Impact")
        {
            var cookmove = other.transform.parent.GetComponentInChildren<FoodCookMove>();
            cookmove.isCombinedArea = true;
            if (GameCtrl.Instance.MouseCtrl.MousePos.isDrag) return;
            // Snap to nearest slot when dragging
            this.SystemCombineFoodCtrl.SystemArrange.SnapToNearestSlot(other.transform);
           // listFood.Add(other.transform.parent);


        }

    }


    protected virtual void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.name == "Impact")
        {
            var cookmove = other.transform.parent.GetComponentInChildren<FoodCookMove>();
           cookmove.isCombinedArea = false;
        }
    }
}



