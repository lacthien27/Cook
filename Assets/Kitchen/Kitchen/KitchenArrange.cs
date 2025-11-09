using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class KitchenArrange : ThienMonoBehaviour
{
    public List<Transform> slots = new List<Transform>(); // 4 slot transform đặt thủ công trong editor
    private Dictionary<Transform, Transform> assignedSlots = new Dictionary<Transform, Transform>();

    // Thêm object
   

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
        Debug.LogWarning(nearest);
        return nearest;
    }
    

    
}
