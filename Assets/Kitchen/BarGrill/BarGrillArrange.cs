using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BarGrillArrange : KitchenArrange
{/**
   [SerializeField] protected Transform Image;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadImage();
        this.AddObjToList();
    }


    protected virtual void LoadImage()
    {
        if (this.Image != null) return;
        this.Image = transform.parent.Find("Image");
        Debug.LogWarning(transform.name + " : Load Image", gameObject);
    }
    
    protected virtual void AddObjToList()
    {
        for (int i = 0; i < Image.childCount; i++)
        {
            Transform slot = Image.GetChild(i);
            slots.Add(slot);
        }
    }**/


}
