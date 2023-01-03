using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropPlace : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        UnitCTRL unitCTRL = eventData.pointerDrag.GetComponent<UnitCTRL>();
        if (unitCTRL != null)
        {
            unitCTRL.defaultParent = transform;
        }
    }
}
