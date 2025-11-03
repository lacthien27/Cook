using UnityEngine;

public interface IsPickupAble
{

  // Interface for objects that can be picked up, dragged, and dropped
  //  void OnPickup(); // Khi được nhặt
  /**void OnDrag(Transform obj)
   {
        
        if (isPickUp == true) return;
        if (isAreaMouse == true && GameCtrl.Instance.MouseCtrl.MousePos.isDrag)
        {
            var objmove = obj.GetComponent<FoodMove>();
            objmove.Move();
        }
    }**/
  // Khi đang được kéo

  void OnDrag();

  void OnDrop(); // Khi được thả


  bool isAreaMouse { get; set; }
  bool isPickUp { get; set; }

}