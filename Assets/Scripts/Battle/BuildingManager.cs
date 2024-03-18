using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperTiled2Unity;
using UnityEngine.EventSystems;
using System;

public class BuildingManager : MonoBehaviour
{
    public static BuildingManager Instance { get; private set;}

    public event EventHandler<OnActiveUnitChangedEventArgs> OnActiveUnitChanged;

    public class OnActiveUnitChangedEventArgs : EventArgs
    {
        public BaseUnitEntity ActiveUnit;
    }

    public UnitList unitList;
    private BaseUnitEntity activeUnit;
    public Grid tilemap;
    [SerializeField] private GameObject unitPrefab;


    private void Awake()
    {
        Instance = this;


    }

    // Update is called once per frame
    void Update()
    {
        if (activeUnit != null )
        {
            if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
            {
                unitPrefab.GetComponent<SpriteRenderer>().sprite = activeUnit.Icon;

                Instantiate(unitPrefab, UtilsClass.GetMouseWorldPosition(), Quaternion.identity);

                UnitSelectUI.Instance.HideUnitButton();

            }
            else if (Input.GetMouseButtonDown(1))
            {
                SetActiveUnit(null);
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(1))
            {
                
                {
                    UnitControllor.Instance.CloseAction();

                }
            }
        }
    }
    public void SetActiveUnit(BaseUnitEntity unit)
    {
        activeUnit = unit;

        OnActiveUnitChanged?.Invoke(this, new OnActiveUnitChangedEventArgs {ActiveUnit = activeUnit });

    }

    public BaseUnitEntity GetActiveUnit()
    {
        return activeUnit;
    }

    private bool CanSpawnBuilding(BuildingTypeEntity buildingTypeEntity, Vector3 position)
    {
        BoxCollider2D boxCollider2D = buildingTypeEntity.prefab.GetComponent<BoxCollider2D>();

        Collider2D[] collider2DArray = Physics2D.OverlapBoxAll(position + (Vector3)boxCollider2D.offset, boxCollider2D.size, 0);

        bool isAreaClear = collider2DArray.Length == 0;
        if (!isAreaClear) return false;

        collider2DArray = Physics2D.OverlapCircleAll(position, buildingTypeEntity.minConstructionRadius);

        foreach(Collider2D collider2D in collider2DArray)
        {
            //Colliders inside the construction radius
            BuildingTypeHolder buildingTypeHolder = collider2D.GetComponent<BuildingTypeHolder>();
            if (buildingTypeHolder != null)
            {
                //Has a BuildingTypeHolder
                if (buildingTypeHolder.buildingType == buildingTypeEntity)
                {
                    //Theres already a building of this type within the construction radius!
                    return false;
                }
            }
        }

        float maxConstructionRadius = 25;
        collider2DArray = Physics2D.OverlapCircleAll(position, maxConstructionRadius);

        foreach (Collider2D collider2D in collider2DArray)
        {
            //Colliders inside the construction radius
            BuildingTypeHolder buildingTypeHolder = collider2D.GetComponent<BuildingTypeHolder>();
            if (buildingTypeHolder != null)
            {
                Debug.Log("buildingTypeHolder = " + buildingTypeHolder);

                //Its a building!
                return true;
            }
        }

        return false;
    }

    
   
}
