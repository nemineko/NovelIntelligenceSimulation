using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance { get; private set;}


    public event EventHandler OnResourceAmountChanged;



    private Dictionary<ResourceTypeEntity, int> resouceAmountDictionary;

    private void Awake()
    {
        Instance = this;

        resouceAmountDictionary = new Dictionary<ResourceTypeEntity, int>();

        ResourceTypeList resourceTypeList  = Resources.Load<ResourceTypeList>(typeof(ResourceTypeList).Name);

        foreach(ResourceTypeEntity resourceType in resourceTypeList.list)
        {
            resouceAmountDictionary[resourceType] = 0;
        }

        TestLogResourceAmountDictionary();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            ResourceTypeList resourceTypeList = Resources.Load<ResourceTypeList>(typeof(ResourceTypeList).Name);
            AddResource(resourceTypeList.list[0], 2);
            TestLogResourceAmountDictionary();
        }
    }

    private void TestLogResourceAmountDictionary()
    {
        foreach(ResourceTypeEntity resourceType in resouceAmountDictionary.Keys)
        {
            //Debug.Log(resourceType.resourceName + ": " + resouceAmountDictionary[resourceType]);
        }
    }

    public void AddResource(ResourceTypeEntity resourceType, int amount)
    {
        resouceAmountDictionary[resourceType] += amount;

        OnResourceAmountChanged?.Invoke(this, EventArgs.Empty);

        TestLogResourceAmountDictionary();

    }

    public int GetResourseAmount(ResourceTypeEntity resourceType)
    {
        return resouceAmountDictionary[resourceType];
    }
}
