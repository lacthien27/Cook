using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcAbs : ThienMonoBehaviour
{
   
    [SerializeField] protected NpcCtrl npcCtrl;

  public NpcCtrl NpcCtrl => npcCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTetrominoCtrl();
    }

    protected virtual void LoadTetrominoCtrl()
    {
        if(this.npcCtrl!=null) return;
        this.npcCtrl = transform.parent.GetComponent<NpcCtrl>();
        Debug.LogWarning(transform.name +" : Load NpcCtrl" ,gameObject);
    }


}
