using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BaseUnitEntity", menuName ="Create Base Unit")]
public class BaseUnitEntity : ScriptableObject
{
    public new string name;
    public int level;
    public int hp;
    public int atk;
    public int def;
    public int spd;
    public int ability_building;
    public int ability_communication;
    public int ability_command;
    public Sprite Icon;
    public GameObject prefab;
}
