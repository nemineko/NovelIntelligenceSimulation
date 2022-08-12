using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCardModel
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

    public PlayerCardModel(int cardID)
    {
        PlayerCardEntity playerCardEntity = Resources.Load<PlayerCardEntity>("PlayerCardEntityList/card_" + cardID);
        name = playerCardEntity.name;
        hp = playerCardEntity.hp;
        atk = playerCardEntity.atk;
        def = playerCardEntity.def;
        spd = playerCardEntity.spd;
        level = playerCardEntity.level;
        timecost = playerCardEntity.timecost;
        icon = playerCardEntity.icon;
        id = playerCardEntity.id;
    }
}
