using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcoalAbs : ThienMonoBehaviour
{
    [SerializeField] protected CharcoalCtrl charcoalCtrl;

    public CharcoalCtrl CharcoalCtrl => charcoalCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCharcoalCtrl();
    }

    protected virtual void LoadCharcoalCtrl()
    {
        if (this.charcoalCtrl != null) return;
        this.charcoalCtrl = transform.parent.GetComponent<CharcoalCtrl>();
        Debug.LogWarning(transform.name + " : Load CharcoalCtrl", gameObject);
    }
    


    
}
