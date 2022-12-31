using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BaseCardEntity", menuName ="Create Base Card")]
public class BaseCardEntity : ScriptableObject
{
    public new string name;
    public int level;
    public int hp;
    public int atk;
    public int def;
    public int spd;
    public int timecost;
    public Sprite playerIcon;
    public Sprite enemyIcon;
    public Transform prefabCardUI;
    public Transform prefabUnitUI;
    public int id;
}
