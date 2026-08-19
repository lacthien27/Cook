using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemCombineFoodImpact : SystemCombineFoodAbs
{

    private HashSet<Transform> candidates = new HashSet<Transform>(); // lưu trữ các đối tượng đang trong vùng ảnh hưởng
    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.name == "Impact" || other.transform.name == "DishImpact" || other.transform.name == "TableWareImpact")
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
            this.systemCombineFoodCtrl.SystemCombineArrange.UpdatePositions();
            if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag && candidates.Contains(obj))
            {
                this.SystemCombineFoodCtrl.SystemCombineArrange.AddObject(obj);
                this.candidates.Remove(obj);
               // GameCtrl.Instance.SpawnerTableWare.SpawnPlate(obj.position); // spawn bộ đồ ăn mới khi đặt món vào hệ thống
                 //               Debug.Log("Add Object to Combine Arrange: " + obj.name);

            }
        }
         if (other.transform.name == "DishImpact")
        {
            var dish = other.transform.parent;
            var dishMove = other.transform.parent.GetComponentInChildren<DishMove>();
              dishMove.isPlaced = true;    //  nếu đặt ở enter sẽ bị lỗi 2 systemcombine ko enter cùng lúc -> object sẽ trả lại vị trí ban đầu

           // this.systemCombineFoodCtrl.SystemCombineArrange.UpdatePositions();
            if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag && candidates.Contains(dish))
            {
                this.SystemCombineFoodCtrl.SystemCombineArrange.AddObject(dish);
                this.candidates.Remove(dish);
            }
        }
       /* if (other.transform.name == "TableWareImpact")
        {
            var tableWare = other.transform.parent;
            var tableWareMove = other.transform.parent.GetComponentInChildren<TableWareMove>();
            tableWareMove.isPlaced = true;    //  nếu đặt ở enter sẽ bị lỗi 2 systemcombine ko enter cùng lúc -> object sẽ trả lại vị trí ban đầu

           // this.systemCombineFoodCtrl.SystemCombineArrange.UpdatePositions();
            if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag && candidates.Contains(tableWare))
            {
                this.SystemCombineFoodCtrl.SystemCombineArrange.AddObject(tableWare);
                this.candidates.Remove(tableWare);
            }
        }*/
    }
    protected virtual void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.name == "Impact")
        {
            var obj = other.transform.parent;
            var cookmove = other.transform.parent.GetComponentInChildren<FoodMove>();
            cookmove.isPlaced = false;
            this.SystemCombineFoodCtrl.SystemCombineArrange.RemoveObject(other.transform.parent);
            candidates.Remove(obj);
        }
        if (other.transform.name == "DishImpact")
        {
            var dish = other.transform.parent;
            var dishMove = other.transform.parent.GetComponentInChildren<DishMove>();
            dishMove.isPlaced = false;
            this.SystemCombineFoodCtrl.SystemCombineArrange.RemoveObject(other.transform.parent);
            candidates.Remove(dish);

        }
        /*if(other.transform.name == "TableWareImpact")
        {
            var tableWare = other.transform.parent;
            var tableWareMove = other.transform.parent.GetComponentInChildren<TableWareMove>();
            tableWareMove.isPlaced = false;
            this.SystemCombineFoodCtrl.SystemCombineArrange.RemoveObject(other.transform.parent);
            candidates.Remove(tableWare);

        } */
    }

}



