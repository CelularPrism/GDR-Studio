using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    void Update()
    {
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        
        if (CheckMousePos(mousePos) && Input.GetMouseButton(0))
        {
            transform.position = new Vector3(mousePos.x, mousePos.y, 0f);
        }
    }

    private bool CheckMousePos(Vector3 mousePos)
    {
        Vector3 pos = transform.position;
        Vector3 scale = transform.localScale;

        if ((mousePos.x <= pos.x + scale.x / 2 && mousePos.x >= pos.x - scale.x / 2) &&
            (mousePos.y <= pos.y + scale.y / 2 && mousePos.y >= pos.y - scale.y / 2))
        {
            return true;
        }

        return false;
    }
}
