using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "GeneralList")]

public class GeneralList : ScriptableObject
{
    public List<GeneralEntity> playerGeneralList;
    public List<GeneralEntity> enemyGeneralList;
}
