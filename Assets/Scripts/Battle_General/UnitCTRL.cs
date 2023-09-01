using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class UnitCTRL : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    private Camera mainCamera;
    private UnitList unitList;
    private BaseCardEntity activeCardType;
    public Transform defaultParent;



    private void Awake()
    {

        unitList = Resources.Load<UnitList>(typeof(UnitList).Name);
    }

    void Start()
    {
        mainCamera = Camera.main;
    }
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        //Mathf.Clamp();
    }
    public void OnEndDrag(PointerEventData eventData)
    {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }
}
