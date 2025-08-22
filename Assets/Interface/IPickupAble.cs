public interface IsPickupAble
{

  // Interface for objects that can be picked up, dragged, and dropped
  void OnPickup(); // Khi được nhặt
  void OnDrag(); // Khi đang được kéo
  void OnDrop(); // Khi được thả


  bool isAreaImpact { get; set; }
  bool isPickUp { get; set; }

}