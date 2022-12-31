using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "UnitList")]

public class UnitList : ScriptableObject
{
    public List<BaseCardEntity> playerUnitList;
    public List<BaseCardEntity> enemyUnitList;
}
