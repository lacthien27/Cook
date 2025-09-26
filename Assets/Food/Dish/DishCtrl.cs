using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishCtrl : ThienMonoBehaviour
{
     [SerializeField] protected DishPro dishPro;
    public DishPro DishPro => dishPro;

    [SerializeField] protected DishImpact dishImpact;
    public DishImpact DishImpact => dishImpact;


    [SerializeField] protected DishPickUp dishPickUp;
    public DishPickUp DishPickUp => dishPickUp;


    [SerializeField] protected DishMove dishMove;
    public DishMove DishMove => dishMove;

    [SerializeField] protected DishTurnOff dishTurnOff;
    public DishTurnOff DishTurnOff => dishTurnOff;
 
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDishPro();
        this.LoadDishImpact();
        this.LoadDishMove();
        this.LoadDishPickUp();
        this.LoadDishTurnOff();
   
    }

 

    protected virtual void LoadDishTurnOff()
    {
        if (this.dishTurnOff != null) return;
        this.dishTurnOff = GetComponentInChildren<DishTurnOff>();
        Debug.LogWarning(transform.name + " : Load DishTurnOff", gameObject);
    }

    protected virtual void LoadDishMove()
    {
        if (this.dishMove != null) return;
        this.dishMove = GetComponentInChildren<DishMove>();
        Debug.LogWarning(transform.name + " : Load DishMove", gameObject);
    }

    protected virtual void LoadDishPickUp()
    {
        if (this.dishPickUp != null) return;
        this.dishPickUp = GetComponentInChildren<DishPickUp>();
        Debug.LogWarning(transform.name + " : Load DishPickUp", gameObject);
    }


    protected virtual void LoadDishPro()
    {
        if (this.dishPro != null) return;
        this.dishPro = GetComponentInChildren<DishPro>();
        Debug.LogWarning(transform.name + " : Load DishPro", gameObject);
    }
    
    protected virtual void LoadDishImpact()
    {
        if (this.dishImpact != null) return;
        this.dishImpact = GetComponentInChildren<DishImpact>();
        Debug.LogWarning(transform.name + " : Load DishImpact", gameObject);
    }
}
