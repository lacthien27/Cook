using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class KitchenArrange : ThienMonoBehaviour
{

    [SerializeField] protected Transform Image;

    public List<Transform> slots = new List<Transform>();
    private Dictionary<Transform, Transform> assignedSlots = new Dictionary<Transform, Transform>();

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
        if(slots.Count > 0) return;
        for (int i = 0; i < Image.childCount; i++)
        {
            Transform slot = Image.GetChild(i);
            slots.Add(slot);
        }
    }




    public void AddObject(Transform obj)
    {
        Transform nearestSlot = GetNearestAvailableSlot(obj.position);

        if (nearestSlot != null)
        {
            Debug.LogWarning("AddObject: " + obj.name + " to " + nearestSlot.name);
            assignedSlots[obj] = nearestSlot;
            obj.position = nearestSlot.position;
        }
    }

    // Xóa object
    public void RemoveObject(Transform obj)
    {
        if (assignedSlots.ContainsKey(obj))
        {
            assignedSlots.Remove(obj);
        }
    }

    // Tìm slot gần nhất
    public Transform GetNearestAvailableSlot(Vector3 objPos)
    {
        Transform nearest = null;
        float minDist = Mathf.Infinity;

        foreach (var slot in slots)
        {
            // check nếu slot chưa bị chiếm
            if (!assignedSlots.ContainsValue(slot))
            {
                float dist = Vector3.Distance(objPos, slot.position);
                if (dist < minDist)
                {
                    minDist = dist;
                    nearest = slot;
                }
            }
        }
        //Debug.LogWarning(nearest);
        return nearest;
    }
    

    
}
