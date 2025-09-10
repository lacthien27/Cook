using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemCombineFoodImpact : SystemCombineFoodAbs
{

    private HashSet<Transform> candidates = new HashSet<Transform>();




    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.name == "Impact")
        {
            var obj = other.transform.parent;
            this.candidates.Add(obj);
        }

    }
    protected virtual void OnTriggerStay2D(Collider2D other)
    {

        if (other.transform.name == "Impact")
        {
            var obj = other.transform.parent;
            var cookmove = other.transform.parent.GetComponentInChildren<FoodCookMove>();
            cookmove.isCombinedArea = true;    //  nếu đặt ở enter sẽ bị lỗi 2 systemcombine ko enter cùng lúc -> object sẽ trả lại vị trí ban đầu

            this.systemCombineFoodCtrl.SystemCombineArrange.UpdatePositions();
            if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag && candidates.Contains(obj))
            {
                this.SystemCombineFoodCtrl.SystemCombineArrange.AddObject(other.transform.parent);
                this.candidates.Remove(obj);
            }
        }
    }

    protected virtual void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.name == "Impact")
        {
            var obj = other.transform.parent;
            var cookmove = other.transform.parent.GetComponentInChildren<FoodCookMove>();
            cookmove.isCombinedArea = false;
            this.SystemCombineFoodCtrl.SystemCombineArrange.RemoveObject(other.transform.parent);
            candidates.Remove(obj);

        }
    }

    
    


 
}



