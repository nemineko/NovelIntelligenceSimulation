using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance { get; private set;}


    public event EventHandler OnResourceAmountChanged;



    private Dictionary<ResourceTypeEntity, int> resourceAmountDictionary;

    private void Awake()
    {
        Instance = this;

        resourceAmountDictionary = new Dictionary<ResourceTypeEntity, int>();

        ResourceTypeList resourceTypeList  = Resources.Load<ResourceTypeList>(typeof(ResourceTypeList).Name);

        foreach(ResourceTypeEntity resourceType in resourceTypeList.list)
        {
            resourceAmountDictionary[resourceType] = 0;
        }

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            ResourceTypeList resourceTypeList = Resources.Load<ResourceTypeList>(typeof(ResourceTypeList).Name);
            AddResource(resourceTypeList.list[0], 2);
        }
    }

    private void TestLogResourceAmountDictionary()
    {
        foreach(ResourceTypeEntity resourceType in resourceAmountDictionary.Keys)
        {
            //Debug.Log(resourceType.resourceName + ": " + resouceAmountDictionary[resourceType]);
        }
    }

    public void AddResource(ResourceTypeEntity resourceType, int amount)
    {
        resourceAmountDictionary[resourceType] += amount;

        OnResourceAmountChanged?.Invoke(this, EventArgs.Empty);


    }

    public int GetResourseAmount(ResourceTypeEntity resourceType)
    {
        return resourceAmountDictionary[resourceType];
    }
}
