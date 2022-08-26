using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class UnitMovement : MonoBehaviour
{
    bool isDragging;
    GameManager gameManager;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnBeginDrag();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            OnEndDrag();
        }
        else if (isDragging)
        {
            OnDragging();
        }
    }
     public void OnBeginDrag()
     {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D raycastHit2D = Physics2D.Raycast(mousePosition, Vector2.zero);
        if (raycastHit2D && raycastHit2D.collider.GetComponent<UnitCTRL>())
        {
            isDragging = true;
        }
     }
     public void OnDragging()
    {

    }
     public void OnEndDrag()
     {
        isDragging = false;
        
     }
}
