using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableWareAbs : ThienMonoBehaviour
{
        [SerializeField] protected TableWareCtrl tableWareCtrl;

  public TableWareCtrl TableWareCtrl => tableWareCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTetrominoCtrl();
    }

    protected virtual void LoadTetrominoCtrl()
    {
        if(this.tableWareCtrl!=null) return;
        this.tableWareCtrl = transform.parent.GetComponent<TableWareCtrl>();
        Debug.LogWarning(transform.name +" : Load TableWareCtrl" ,gameObject);
    }
}
