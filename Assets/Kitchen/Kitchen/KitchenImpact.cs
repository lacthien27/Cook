using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KitchenImpact : KitchenAbs
{
    [SerializeField] public float cookTimeAdd = 0f;

        [SerializeField] public float burnTimeAdd = 0f;


        private HashSet<Transform> candidates = new HashSet<Transform>();// lưu trữ các object đang trong vùng impact

        protected virtual void OnTriggerEnter2D(Collider2D other)
        {
        if (other.transform.name == "Impact")
        {
            var obj = other.transform.parent;
            this.candidates.Add(obj);
        }

        if(other.transform.name =="CharcoalImpact")
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
            cookmove.isPlaced = true;    //  nếu đặt ở enter sẽ bị lỗi 2 systemcombine ko enter cùng lúc -> object sẽ trả lại vị trí ban đầu

            if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag && candidates.Contains(obj))
            {
                this.kitchenCtrl.KitchenArrange.AddObject(obj); // add obj vào slot khi thả obj , phục vụ cho việc sắp xếp
                this.candidates.Remove(obj);
                this.kitchenCtrl.KitchenScreening.ScreeningFood(obj);  // screening khi thả obj 
                var ObjTimer = obj.GetComponent<FoodCtrl>().FoodTimer;
                ObjTimer.StartCooking();
                ObjTimer.StartCookingAgain();
            }
            if (GameCtrl.Instance.MouseCtrl.MousePos.isDrag && !candidates.Contains(obj))
            {
                this.candidates.Add(obj);
                this.kitchenCtrl.KitchenArrange.RemoveObject(obj);// rest slot khi đang kéo, thiếu sẽ bị lỗi obj còn lại di chuyển khi 1 obj khác di chuyển
            }

        }

        if (other.transform.name == "CharcoalImpact")
        {
            var CharcoalCtrl = other.transform.parent;
            var CharcoalMove = other.transform.parent.GetComponentInChildren<CharcoalMove>();
            CharcoalMove.isPlaced = true;    //  nếu đặt ở enter sẽ bị lỗi 2 systemcombine ko enter cùng lúc -> object sẽ trả lại vị trí ban đầu

            if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag && candidates.Contains(CharcoalCtrl))
            {
                this.kitchenCtrl.KitchenState.AddCharcoal();
                this.candidates.Remove(CharcoalCtrl);
                var CharcoalTurnOff = CharcoalCtrl.GetComponentInChildren<CharcoalTurnOff>();
                CharcoalTurnOff.TurnOff();
            }
        }
    }
        protected virtual void OnTriggerExit2D(Collider2D other)
        {
        if (other.transform.name == "Impact")
        {
            var obj = other.transform.parent;
            var foodmove = other.transform.parent.GetComponentInChildren<FoodMove>();

            foodmove.isPlaced = false;
            this.kitchenCtrl.KitchenArrange.RemoveObject(obj);

            this.candidates.Remove(obj);

            var ObjTimer = obj.GetComponent<FoodCtrl>().FoodTimer;
            ObjTimer.StopCooking();

            

        }
        }



     
   


}
