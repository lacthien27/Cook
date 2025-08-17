using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SystemArrange : SystemCombineFoodAbs
{
    public List<Transform> arrangedObjects = new List<Transform>();

    public Vector2 startPos = new Vector2(-1.5f, 0f);// phỉa là vị trí của transform.parrent
    public float offsetX = 1.0f;


    protected bool isOneSignal = false;

    // Hàm thêm object vào hàng
    public void AddObject(Transform obj)
    {
        if (arrangedObjects.Contains(obj)) return;
        arrangedObjects.Add(obj);
        UpdatePositions();
        //this.isOneSignal = false; // Reset the signal after adding an object
        
    }

    // Hàm xóa object ra khỏi hàng
    public void RemoveObject(Transform obj)
    {
        if (arrangedObjects.Contains(obj))
        {
            arrangedObjects.Remove(obj);
            UpdatePositions();
        }
    }

    // Sắp xếp lại vị trí toàn bộ object dựa theo index
    private void UpdatePositions()
    {
        for (int i = 0; i < arrangedObjects.Count; i++)
        {
            Vector2 targetPos = startPos + new Vector2(i * offsetX, 0);
            arrangedObjects[i].position = targetPos;
        }
    }


    public void OnlyHandleWhenOnceImpact(Transform obj)
    {
        if (GameCtrl.Instance.MouseCtrl.MousePos.isDrag) return;
        if (isOneSignal) return;
        isOneSignal = true;
        AddObject(obj);
        Debug.Log("Added object: " + obj.transform.name);
        Debug.LogWarning(arrangedObjects.Count);
    }

}
