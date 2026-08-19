using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TableWareMove : MoveObjAbs
{
    [SerializeField] protected TableWareCtrl tableWareCtrl;

    public TableWareCtrl TableWareCtrl => tableWareCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTableWareCtrl();
    }
    
    protected virtual void LoadTableWareCtrl()
    {
        if (this.tableWareCtrl != null) return;
        this.tableWareCtrl = transform.parent.GetComponent<TableWareCtrl>();
        Debug.LogWarning(transform.name + " : Load TableWareCtrl", gameObject);
    }
    
}
