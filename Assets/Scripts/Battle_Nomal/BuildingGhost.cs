using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGhost : MonoBehaviour
{
    private GameObject spriteGameObject;
    private void Awake()
    {
        spriteGameObject = transform.Find("Sprite").gameObject;
        Hide();
    }
    private void Start()
    {
        BuildingManager.Instance.OnActiveBuildingTypeChanged += BuildingManager_OnActiveBuildingTypeChanged;
    }
    private void BuildingManager_OnActiveBuildingTypeChanged(object sender, BuildingManager.OnActiveBuildingTypeChangedEventArgs e)
    {
        if (e.activeBuildingType == null)
        {
            Hide();           
        }
        else
        {
            Show(e.activeBuildingType.sprite);
        }
    }
    private void Update()
    {
        transform.position = UtilsClass.GetMouseWorldPosition();
    }
    private void Show(Sprite cursor)
    {
        spriteGameObject.SetActive(true);
        spriteGameObject.GetComponent<SpriteRenderer>().sprite = cursor;
    }
    private void Hide()
    {
        spriteGameObject.SetActive(false);
    }
}
