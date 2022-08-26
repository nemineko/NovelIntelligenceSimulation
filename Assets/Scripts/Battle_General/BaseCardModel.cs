using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCardModel
{
    public string name;
    public int level;
    public int hp;
    public int atk;
    public int def;
    public int spd;
    public int timecost;
    public Sprite icon;
    public bool player;
    public int id;

    public BaseCardModel(int cardID)
    {
        BaseCardEntity baseCardEntity = Resources.Load<BaseCardEntity>("BaseCardEntityList/card_" + cardID);
        name = baseCardEntity.name;
        hp = baseCardEntity.hp;
        atk = baseCardEntity.atk;
        def = baseCardEntity.def;
        spd = baseCardEntity.spd;
        level = baseCardEntity.level;
        timecost = baseCardEntity.timecost;
        icon = baseCardEntity.icon;
        player = baseCardEntity.player;
        id = baseCardEntity.id;
    }
}
