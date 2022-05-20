using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropPlace : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        CardMovement unit = eventData.pointerDrag.GetComponent<CardMovement>();
        if (unit != null)
        {
            unit.defaultParent = this.transform;
        }

    }
}
