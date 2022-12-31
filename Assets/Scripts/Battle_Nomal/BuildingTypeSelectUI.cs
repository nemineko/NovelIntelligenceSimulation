using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BuildingTypeSelectUI : MonoBehaviour
{
    [SerializeField] private Sprite arrowSprite;

    private Dictionary<BuildingTypeEntity, Transform> btnTransformDictionary;
    private Transform arrowBtn;

    private void Awake()
    {
        Transform btnTemplate = transform.Find("btnTemplate");
        btnTemplate.gameObject.SetActive(false);

        BuildingTypeList buildingTypeList = Resources.Load<BuildingTypeList>(typeof(BuildingTypeList).Name);
        btnTransformDictionary = new Dictionary<BuildingTypeEntity, Transform>();

        int index = 0;
        float offsetAmount = -520f;


        arrowBtn = Instantiate(btnTemplate, transform);
        arrowBtn.gameObject.SetActive(true);

        arrowBtn.GetComponent<RectTransform>().anchoredPosition = new Vector2(offsetAmount * index, -400);

        arrowBtn.Find("Image").GetComponent<Image>().sprite = arrowSprite;
       // arrowBtn.Find("Image").GetComponent<RectTransform>().sizeDelta = new Vector2(0,0);

        arrowBtn.GetComponent<Button>().onClick.AddListener(() =>
        {
            BuildingManager.Instance.SetActiveBuildingType(null);
        });

        index++;

        foreach (BuildingTypeEntity buildingType in buildingTypeList.list)
        {
            Transform btnTransform = Instantiate(btnTemplate, transform);
            btnTransform.gameObject.SetActive(true);

            offsetAmount = +280f;
            btnTransform.GetComponent<RectTransform>().anchoredPosition = new Vector2(offsetAmount * index, -400);

            btnTransform.Find("Image").GetComponent<Image>().sprite = buildingType.sprite;

            btnTransform.GetComponent<Button>().onClick.AddListener(() => 
            {
                BuildingManager.Instance.SetActiveBuildingType(buildingType);
            });

            btnTransformDictionary[buildingType] = btnTransform;

            index++;

        }

    }

    private void Update()
    {
        UpdateActiveBuildingTypeButton();
    }
    private void UpdateActiveBuildingTypeButton()
    {
        arrowBtn.Find("selected").gameObject.SetActive(false);
        foreach(BuildingTypeEntity buildingType in btnTransformDictionary.Keys)
        {
            Transform btnTransform = btnTransformDictionary[buildingType];
            btnTransform.Find("selected").gameObject.SetActive(false);
        }

        BuildingTypeEntity activeBuildingType = BuildingManager.Instance.GetActiveBuildingType();
        if (activeBuildingType == null)
        {
            arrowBtn.Find("selected").gameObject.SetActive(true);
        }
        else
        {
            btnTransformDictionary[activeBuildingType].Find("selected").gameObject.SetActive(true);

        }
    }
}
