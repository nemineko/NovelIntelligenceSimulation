using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperTiled2Unity;
using UnityEngine.Tilemaps;
using UnityEngine.EventSystems;

public class BuildingManager : MonoBehaviour
{
    public static BuildingManager Instance { get; private set;}
    private Camera mainCamera;
    private BuildingTypeList buildingTypeList;
    private BuildingTypeEntity activeBuildingType;
    [SerializeField]private Grid tilemap;

    private void Awake()
    {
        Instance = this;


        buildingTypeList = Resources.Load<BuildingTypeList>(typeof(BuildingTypeList).Name);
    }

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            if (activeBuildingType != null)
            {
                Instantiate(activeBuildingType.prefab, GetMouseWorldPosition(), Quaternion.identity);
            }
        }
    }
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        Vector3Int tilemapMousePosition = tilemap.WorldToCell(mouseWorldPosition);
        return tilemapMousePosition;
    }

    public void SetActiveBuildingType(BuildingTypeEntity buildingType)
    {
        activeBuildingType = buildingType;
    }

    public BuildingTypeEntity GetActiveBuildingType()
    {
        return activeBuildingType;
    }
}
