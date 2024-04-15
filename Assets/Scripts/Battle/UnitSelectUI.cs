using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UnitSelectUI : MonoBehaviour
{
    [SerializeField] private Sprite arrowSprite;
    [SerializeField] private List<BaseUnitEntity> ignoreBaceUnitList;
    private UnitList unitList;
    private Dictionary<BaseUnitEntity, Transform> btnTransformDictionary;
    private Transform arrowBtn;
    [SerializeField] private GameObject btnTemplate;

    public static UnitSelectUI Instance { get; private set; }

    private void Awake()
    {
        Instance = this;

        unitList = BuildingManager.Instance.unitList;
        btnTransformDictionary = new Dictionary<BaseUnitEntity, Transform>();
        InstantiateButton();
        UpdateActiveUnitButton();

    }
    private void Start()
    {
        BuildingManager.Instance.OnActiveUnitChanged += BuildingManager_OnActiveUnitChanged;
    }
    private void InstantiateButton()
    {
        int index = 0;
        float offsetAmount = -520f;

        arrowBtn = Instantiate(btnTemplate.transform, transform);
        arrowBtn.gameObject.SetActive(true);

        arrowBtn.GetComponent<RectTransform>().anchoredPosition = new Vector2(offsetAmount * index, -400);

        arrowBtn.Find("Image").GetComponent<Image>().sprite = arrowSprite;

        arrowBtn.GetComponent<Button>().onClick.AddListener(() =>
        {
            BuildingManager.Instance.SetActiveUnit(null);
        });

        index++;

        foreach (BaseUnitEntity unit in unitList.playerUnitList)
        {
            if (ignoreBaceUnitList.Contains(unit)) continue;
            Transform btnTransform = Instantiate(btnTemplate.transform, transform);
            btnTransform.gameObject.SetActive(true);

            offsetAmount = +280f;
            btnTransform.GetComponent<RectTransform>().anchoredPosition = new Vector2(offsetAmount * index, -400);

            btnTransform.Find("Image").GetComponent<Image>().sprite = unit.Icon;

            btnTransform.GetComponent<Button>().onClick.AddListener(() =>
            {
                BuildingManager.Instance.SetActiveUnit(unit);
            });

            btnTransformDictionary[unit] = btnTransform;

            index++;

        }
        
        
    }
    private void BuildingManager_OnActiveUnitChanged(object sender, BuildingManager.OnActiveUnitChangedEventArgs e)
    {
        UpdateActiveUnitButton();

    }
    
    private void UpdateActiveUnitButton()
    {
        arrowBtn.Find("selected").gameObject.SetActive(false);

        foreach(var keyValue in btnTransformDictionary)
        {
            if(!keyValue.Value) continue;
            keyValue.Value.Find("selected").gameObject.SetActive(false);
        }

        BaseUnitEntity activeBuildingType = BuildingManager.Instance.GetActiveUnit();
        if (activeBuildingType == null)
        {
            arrowBtn.Find("selected").gameObject.SetActive(true);

        }
        else
        {
            btnTransformDictionary[activeBuildingType].Find("selected").gameObject.SetActive(true);

        }
    }
    public void HideUnitButton()
    {
        ignoreBaceUnitList.Add(BuildingManager.Instance.GetActiveUnit());
        int units = transform.childCount;
        for (int i = 0; i < units; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        if (ignoreBaceUnitList.Count != unitList.playerUnitList.Count)
        {
            InstantiateButton();
            UpdateActiveUnitButton();
        }
        BuildingManager.Instance.SetActiveUnit(null);

    }
}
