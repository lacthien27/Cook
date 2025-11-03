using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcoalCtrl : ThienMonoBehaviour
{
    [SerializeField] protected CharcoalImpact charcoalImpact;
   
    public CharcoalImpact CharcoalImpact => charcoalImpact;


   [SerializeField] protected CharcoalTurnOff charcoalTurnOff;

    public CharcoalTurnOff CharcoalTurnOff => charcoalTurnOff;
   

   protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCharcoalImpact();
        this.LoadCharcoalTurnOff();
    }

    protected virtual void LoadCharcoalImpact()
    {
        if (this.charcoalImpact != null) return;
        this.charcoalImpact = GetComponentInChildren<CharcoalImpact>();
        Debug.LogWarning(transform.name + " : Load CharcoalImpact", gameObject);
    }

    protected virtual void LoadCharcoalTurnOff()
    {
        if (this.charcoalTurnOff != null) return;
        this.charcoalTurnOff = GetComponentInChildren<CharcoalTurnOff>();
        Debug.LogWarning(transform.name + " : Load CharcoalTurnOff", gameObject);
    }
}
