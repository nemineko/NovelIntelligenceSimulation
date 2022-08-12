using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCardModel
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
    public EnemyCardModel(int cardID)
    {
        EnemyCardEntity enemyCardEntity = Resources.Load<EnemyCardEntity>("EnemyCardEntityList/card_" + cardID);
        name = enemyCardEntity.name;
        hp = enemyCardEntity.hp;
        atk = enemyCardEntity.atk;
        def = enemyCardEntity.def;
        spd = enemyCardEntity.spd;
        level = enemyCardEntity.level;
        timecost = enemyCardEntity.timecost;
        icon = enemyCardEntity.icon;
        id = enemyCardEntity.id;
    }
}
