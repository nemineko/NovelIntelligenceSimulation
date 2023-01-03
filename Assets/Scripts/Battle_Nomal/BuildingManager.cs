using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperTiled2Unity;
using UnityEngine.EventSystems;
using System;

public class BuildingManager : MonoBehaviour
{
    public static BuildingManager Instance { get; private set;}


    public event EventHandler<OnActiveBuildingTypeChangedEventArgs> OnActiveBuildingTypeChanged;

    public class OnActiveBuildingTypeChangedEventArgs : EventArgs
    {
        public BuildingTypeEntity activeBuildingType;
    }


    private Camera mainCamera;
    private BuildingTypeList buildingTypeList;
    private BuildingTypeEntity activeBuildingType;
    public Grid tilemap;

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
                Instantiate(activeBuildingType.prefab, UtilsClass.GetMouseWorldPosition(), Quaternion.identity);
            }
        }
    }

    public void SetActiveBuildingType(BuildingTypeEntity buildingType)
    {
        activeBuildingType = buildingType;

        OnActiveBuildingTypeChanged?.Invoke(this, new OnActiveBuildingTypeChangedEventArgs {activeBuildingType = activeBuildingType });

    }

    public BuildingTypeEntity GetActiveBuildingType()
    {
        return activeBuildingType;
    }
}
