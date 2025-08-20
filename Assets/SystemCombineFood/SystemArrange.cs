using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SystemArrange : SystemCombineFoodAbs
{
    public List<Transform> arrangedObjects = new List<Transform>();

    public bool isSnapped = false;
    public float offsetX = 1.0f;


    public void FixedUpdate()
    {
       // this.DragMoveFood();
    }

    // Hàm thêm object vào hàng
    public void AddObject(Transform obj)
    {
        if (arrangedObjects.Contains(obj)) return;
        arrangedObjects.Add(obj);
        UpdatePositions();
        this.isSnapped = true;


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
    public void UpdatePositions()
    {
        for (int i = 0; i < arrangedObjects.Count; i++)
        {
            Vector2 targetPos = transform.parent.position + new Vector3(-1.5f + i * offsetX, 0, 0);
            arrangedObjects[i].position = targetPos;
        }
    }


 /**
    public void DragMoveFood()
    {
        if (!GameCtrl.Instance.MouseCtrl.MousePos.isDrag) return; // Kiểm tra xem có đang kéo không
        if (!this.isSnapped) return;
        Debug.Log("Dragging food");
        this.RemoveObject(this.transform);
        this.isSnapped = false;
    }
    
**/
    

    
    

}
