using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SystemCombineArrange : SystemCombineFoodAbs
{
    public List<Transform> listDish = new List<Transform>(); //foodForCookCtrl

     public float offsetX = 1.0f;

     // Hàm thêm object vào hàng
     public void AddObject(Transform obj)
     {
         if (listDish.Contains(obj)) return;
         listDish.Add(obj);
         UpdatePositions();



     }

     // Hàm xóa object ra khỏi hàng
     public void RemoveObject(Transform obj)
     {
         if (listDish.Contains(obj))
         {
             listDish.Remove(obj);
             UpdatePositions();
         }
     }

    // Sắp xếp lại vị trí toàn bộ object dựa theo index
    public void UpdatePositions()
    {
        for (int i = 0; i < listDish.Count; i++)
        {
            Vector2 targetPos = transform.parent.position + new Vector3(-1.5f + i * offsetX, 0, 0);
            listDish[i].position = targetPos;

        }
        this.systemCombineFoodCtrl.SystemCombineFood.GetListFoodData();
 
     }


    

}
