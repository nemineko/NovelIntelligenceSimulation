using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ResourceTypeList")]
public class ResourceTypeList : ScriptableObject
{
    public List<ResourceTypeEntity> list;
}
