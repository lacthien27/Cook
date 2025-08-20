using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemCombineFoodImpact : SystemCombineFoodAbs
{
    // [SerializeField] public List<Transform> listFood = new List<Transform>(); // Dùng List thay vì mảng

    private HashSet<Transform> candidates = new HashSet<Transform>();

//        [SerializeField] private float minDistance = 1f; // khoảng cách cần kiểm tra



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
        var obj = other.transform.parent;

        if (other.transform.name == "Impact")
        {
            this.systemCombineFoodCtrl.SystemArrange.UpdatePositions();

            if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag && candidates.Contains(obj))
            {
                this.SystemCombineFoodCtrl.SystemArrange.AddObject(other.transform.parent);
                this.candidates.Remove(obj);

            }
        }
     /**   if(other.transform.name =="MouseImpact"&& !candidates.Contains(obj) )
        {
            // Kiểm tra khoảng cách giữa chuột và đối tượng
            this.DistanceCheck(obj);

        }**/
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
    


  /**  protected  virtual void DistanceCheck(Transform obj)
    {
        // Kiểm tra khoảng cách giữa các đối tượng trong candidates
        float distance = Vector3.Distance(GameCtrl.Instance.MouseCtrl.transform.position, obj.position);
        if (distance >= minDistance)
        {
            Debug.Log("Chuột đã cách object >= " + minDistance + " đơn vị!");
        }
    }**/
}



