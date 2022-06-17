using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="CardEntity", menuName ="Create Card")]
public class CardEntity : ScriptableObject
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
