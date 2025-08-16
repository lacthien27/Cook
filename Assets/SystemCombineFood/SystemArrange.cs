using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemArrange : SystemCombineFoodAbs
{
    public List<Transform> slotPoints = new List<Transform>(); // Dùng List thay vì mảng
    public int rows = 4;
    public float cellSize = 1.0f;
    public Vector2 startPos = new Vector2(-1.5f, 0.0f);

    protected  override void Start()
    {
        GenerateSlots();
    }

    public void SnapToNearestSlot(Transform obj)
    {
      float minDist = float.MaxValue;
    Transform nearest = null;

    foreach (var slot in slotPoints)
    {
        float dist = Vector2.Distance(obj.position, slot.position);
        if (dist < minDist)
        {
            minDist = dist;
            nearest = slot;
        }
    }

    if (nearest != null)
    {
        // Snap trực tiếp object thay vì parent
        obj.position = nearest.position;
    }
    }

    public void GenerateSlots()
    {
        slotPoints.Clear();
        for (int x = 0; x < rows; x++)
        {
            GameObject slot = new GameObject($"Slot__{x}");
            slot.transform.parent = transform;
            slot.transform.localPosition = startPos + new Vector2(x * cellSize,0);
            slotPoints.Add(slot.transform);
        }
        
    }

}
