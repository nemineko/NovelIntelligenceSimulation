using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    UnitList unitList;
    private void Awake()
    {
        unitList = Resources.Load<UnitList>(typeof(UnitList).Name);

    }
    private void Start()
    {
        unitList.playerUnitList.Clear();
        unitList.enemyUnitList.Clear();
    }
}
