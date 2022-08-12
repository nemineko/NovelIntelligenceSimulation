using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyCardEntity", menuName = "Create Enemy Card")]
public class EnemyCardEntity : ScriptableObject
{
    public new string name;
    public int level;
    public int hp;
    public int atk;
    public int def;
    public int spd;
    public int timecost;
    public Sprite icon;
    public int id;
}