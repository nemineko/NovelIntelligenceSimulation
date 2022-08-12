using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PlayerCardEntity", menuName ="Create Player Card")]
public class PlayerCardEntity : ScriptableObject
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
