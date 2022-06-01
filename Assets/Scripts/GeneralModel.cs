using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralModel
{
    public string name;
    public int hp;
    public int atk;
    public int def;
    public int spd;
    public int stm;
    public Sprite icon;

    public GeneralModel(int generalID)
    {
        GeneralEntity cardEntity = Resources.Load<GeneralEntity>("GeneralEntityList/general" + generalID);
        name = cardEntity.name;
        hp = cardEntity.hp;
        atk = cardEntity.atk;
        def = cardEntity.def;
        spd = cardEntity.spd;
        stm = cardEntity.stm;
        icon = cardEntity.icon;
    }
}
