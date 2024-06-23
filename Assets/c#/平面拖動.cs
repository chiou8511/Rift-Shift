using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 平面拖動 : MonoBehaviour
{
    public Camera cam;

    private Vector3 offset;
    private bool isDragging = false;

    void OnMouseDown()
    {
        offset = transform.position - cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x * 1, Input.mousePosition.y * 1, transform.position.z));
        isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x*1, Input.mousePosition.y*1, transform.position.z);
            Vector3 curPosition = cam.ScreenToWorldPoint(curScreenPoint) + offset;
            curPosition.z = 0;
            transform.position = curPosition;
        }
    }

}
