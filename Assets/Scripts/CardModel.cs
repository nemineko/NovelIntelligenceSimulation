using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel
{
    public string name;
    public int hp;
    public int level;
    public int cost;
    public Sprite icon;
    public int cardID;
    
    public CardModel()
    {
        CardEntity cardEntity = Resources.Load<CardEntity>("CardEntityList/" + name + "_level" + level);
        name = cardEntity.name;
        hp = cardEntity.hp;
        level = cardEntity.level;
        cost = cardEntity.cost;
        icon = cardEntity.icon;
        cardID = cardEntity.cardID;
    }
}
