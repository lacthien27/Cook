using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemCombineFoodImpact : SystemCombineFoodAbs
{
    // [SerializeField] public List<Transform> listFood = new List<Transform>(); // Dùng List thay vì mảng

    private HashSet<Transform> candidates = new HashSet<Transform>();


    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.name == "Impact")
        {
            var obj = other.transform.parent;
            var cookmove = other.transform.parent.GetComponentInChildren<FoodCookMove>();
            cookmove.isCombinedArea = true;
            this.candidates.Add(obj);



        }

    }
    


    protected virtual void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.name == "Impact")
        {
            var obj = other.transform.parent;
            if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag
               && candidates.Contains(obj))
            {
                this.SystemCombineFoodCtrl.SystemArrange.AddObject(other.transform.parent);
                                candidates.Remove(obj);

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
           this.SystemCombineFoodCtrl.SystemArrange.RemoveObject(other.transform.parent);
                       candidates.Remove(obj);

        }
    }
}



