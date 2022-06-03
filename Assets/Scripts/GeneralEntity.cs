using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GeneralEntity", menuName = "Create General")]
public class GeneralEntity : ScriptableObject
{
    public new string name;
    public int atk;
    public int def;
    public int spd;
    public int stm;
    public Sprite icon;
}
