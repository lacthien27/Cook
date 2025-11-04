using UnityEngine;

public interface IsPickupAble
{

  // Interface for objects that can be picked up, dragged, and dropped
  //  void OnPickup(); // Khi được nhặt


void OnDrag();

  void OnDrop(); // Khi được thả


  bool isAreaMouse { get; set; }
  bool isPickUp { get; set; }

}