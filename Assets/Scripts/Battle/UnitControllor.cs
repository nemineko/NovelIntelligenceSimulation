using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class UnitControllor : MonoBehaviour, IDragHandler
{
    public static UnitControllor Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        
    }
    
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && BuildingManager.Instance.GetActiveUnit() == null)
        {
            CloseAction();
            Debug.Log("ChoiceAction");
            ChoiceAction();
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
    private void ChoiceAction()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
    public void CloseAction()
    {
        var units = FindObjectsOfType<UnitControllor>();
        foreach (UnitControllor unit in units)
        {
            unit.transform.GetChild(0).gameObject.SetActive(false);
        }
        Debug.Log("CloseAction");
    }
    public void Inut()
    {

    }
    public void Battle()
    {

    }
}
