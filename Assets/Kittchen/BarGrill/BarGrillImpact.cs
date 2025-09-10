using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarGrillImpact : BarGrillAbs
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

            if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag && candidates.Contains(obj))
                {
                this.BarGrillCtrl.BarGrillArrange.AddObject(obj);
                this.candidates.Remove(obj);
                }

            if (GameCtrl.Instance.MouseCtrl.MousePos.isDrag && !candidates.Contains(obj))
            {
                this.candidates.Add(obj);
                this.BarGrillCtrl.BarGrillArrange.RemoveObject(obj);// rest slot khi đang kéo, thiếu sẽ bị lỗi obj còn lại di chuyển khi 1 obj khác di chuyển 

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
                this.BarGrillCtrl.BarGrillArrange.RemoveObject(obj);
                this.candidates.Remove(obj);

            }
        }



     
   


}
