using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel
{
    public string name;
    public int level;
    public int hp;
    public int atk;
    public int def;
    public int spd;
    public int timecost;
    public Sprite icon;
    public int id;

    public CardModel(int cardID)
    {
        CardEntity cardEntity = Resources.Load<CardEntity>("CardEntityList/card_" + cardID);
        name = cardEntity.name;
        hp = cardEntity.hp;
        atk = cardEntity.atk;
        def = cardEntity.def;
        spd = cardEntity.spd;
        level = cardEntity.level;
        timecost = cardEntity.timecost;
        icon = cardEntity.icon;
        id = cardEntity.id;
    }
}
