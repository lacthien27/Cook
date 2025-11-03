using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishMove : MoveObjAbs
{
   
   [SerializeField] protected DishCtrl dishCtrl;

  public DishCtrl DishCtrl => dishCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDishCtrl();
    }

    protected virtual void LoadDishCtrl()
    {
        if(this.dishCtrl!=null) return;
        this.dishCtrl = transform.parent.GetComponent<DishCtrl>();
        Debug.LogWarning(transform.name +" : Load DishCtrl" ,gameObject);
    }



/**   public Vector3 startPos;

   public bool isPlaced = false;  //đúng vị trí thì thoy ko quay về chỗ cũ, xem lại tên đặt tên cho đúng

   protected override void OnEnable()
   {
      this.startPos = this.transform.parent.position;
   }



   public virtual void Move()
   {
      Vector3 mouseWorldPos = GameCtrl.Instance.MouseCtrl.transform.position;
      this.transform.parent.position = mouseWorldPos;
   }
   
   public virtual void ReturnToStartPos()
   {
      
      if (this.isPlaced) return; // true area impact hợp lí thì ko về vị trí ban đầu
      this.transform.parent.position = this.startPos;
      
   }
   **/
}
