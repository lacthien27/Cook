using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishStorageCtrl : ThienMonoBehaviour
{
     protected HashSet<Transform> candidates = new HashSet<Transform>();// lưu trữ các object đang trong vùng impact

    protected bool isBringPlate = false;
    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.name == "MouseImpact")
        {
            var obj = other.transform.parent;
            this.candidates.Add(obj);
        }

       if (other.transform.name == "Impact")
        {
            this.isBringPlate=true;
        }

    }   

     protected virtual void OnTriggerStay2D(Collider2D other)
    {
        var objCtrl = other.transform.parent;
        
            if (GameCtrl.Instance.MouseCtrl.MousePos.isDrag &&  candidates.Contains(objCtrl)&& this.isBringPlate==false) 
            {         
            this.candidates.Remove(objCtrl);
            GameCtrl.Instance.SpawnerIngredient.SpawnRice();
            }
        
    }

      protected virtual void OnTriggerExit2D(Collider2D other)
    {
        
          if (other.transform.name == "MouseImpact")
        {
            var objCtrl = other.transform.parent;
            this.candidates.Remove(objCtrl);
        }

         if (other.transform.name == "Impact")
        {
            this.isBringPlate=false;
        }


    }

}
