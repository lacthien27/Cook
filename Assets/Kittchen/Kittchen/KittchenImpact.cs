using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KittchenImpact : KittchenAbs
{
    [SerializeField] public float cookTimeAdd = 0f;

        [SerializeField] public float burnTimeAdd = 0f;


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
            var cookmove = other.transform.parent.GetComponentInChildren<FoodMove>();
            cookmove.isCombinedArea = true;    //  nếu đặt ở enter sẽ bị lỗi 2 systemcombine ko enter cùng lúc -> object sẽ trả lại vị trí ban đầu

            if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag && candidates.Contains(obj))
            {
                this.kittchenCtrl.KittchenArrange.AddObject(obj);
                this.candidates.Remove(obj);
                this.kittchenCtrl.KittchenScreening.ScreeningFood(obj);  // screening khi thả obj
                var objCtrl = obj.GetComponent<FoodCtrl>();
                var ObjTimer = objCtrl.FoodTimer;
                ObjTimer.burnTime += burnTimeAdd;
                ObjTimer.cookTime += cookTimeAdd;
                ObjTimer.StartCooking();
                }



            if (GameCtrl.Instance.MouseCtrl.MousePos.isDrag && !candidates.Contains(obj))
            {
                this.candidates.Add(obj);
                this.kittchenCtrl.KittchenArrange.RemoveObject(obj);// rest slot khi đang kéo, thiếu sẽ bị lỗi obj còn lại di chuyển khi 1 obj khác di chuyển 

            }
               
            }
        }

        protected virtual void OnTriggerExit2D(Collider2D other)
        {
        if (other.transform.name == "Impact")
        {
            var obj = other.transform.parent;
            var foodmove = other.transform.parent.GetComponentInChildren<FoodMove>();
            foodmove.isCombinedArea = false;
            this.kittchenCtrl.KittchenArrange.RemoveObject(obj);
            this.candidates.Remove(obj);
            var objCtrl = obj.GetComponent<FoodCtrl>();
            var ObjTimer = objCtrl.FoodTimer;
            ObjTimer.StopCooking();



        }
        }



     
   


}
