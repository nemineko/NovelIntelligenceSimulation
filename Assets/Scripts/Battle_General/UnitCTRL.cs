using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class UnitCTRL : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private Camera mainCamera;
    private CardList cardList;
    private BaseCardEntity activeCardType;



    private void Awake()
    {

        cardList = Resources.Load<CardList>(typeof(CardList).Name);
    }

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (activeCardType != null)
            {
                Instantiate(activeCardType.prefabCardUI, GetMouseWorldPosition(), Quaternion.identity);
            }
        }
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
    }
    public void OnEndDrag(PointerEventData eventData)
    {
     
    }

  
}
