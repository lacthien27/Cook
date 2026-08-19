using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableWareCtrl : ThienMonoBehaviour
{
   [SerializeField] protected TableWareMove tableWareMove;
    public TableWareMove TableWareMove => tableWareMove;

     protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTableWareMove();
    }

    protected virtual void LoadTableWareMove()
    {
        if (this.tableWareMove != null) return;
        this.tableWareMove = GetComponentInChildren<TableWareMove>();
        Debug.LogWarning(transform.name + ": LoadTableWareMove", gameObject);
    }
   
}
