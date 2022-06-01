using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="CardEntity", menuName ="Create Card")]
public class CardEntity : ScriptableObject
{
    public new string name;
    public int hp;
    public int level;
    public int cost;
    public Sprite icon;
    public int cardID;
}
