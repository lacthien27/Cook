using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MouseAbs
{

    [SerializeField] public bool isDrag;

    protected virtual void Update()
    {

        this.GetPos();
        this.DragAndDrop();

    }

    protected virtual void GetPos()
    {
        // Lấy vị trí chu
        Vector3 mouseScreenPos = Input.mousePosition;

        // Chuyển sang tọa độ thế giới (World)
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
        mouseWorldPos.z = 0; // Nếu game 2D, giữ z = 0

        this.MouseCtrl.transform.position = mouseWorldPos;

    }
    protected virtual void DragAndDrop()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDrag = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isDrag = false;
        }

        if (isDrag)
        {
            GetPos();
        }
    }


}
