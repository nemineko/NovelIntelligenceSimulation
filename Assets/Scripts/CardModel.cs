using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel
{
    public string name;
    public int level;
    [SerializeField] int hp;
    public int atk;
    public int def;
    public int spd;
    public int timecost;
    public Sprite icon;

    public int Hp { get => hp; }

    public CardModel(int cardID)
    {
        CardEntity cardEntity = Resources.Load<CardEntity>("CardEntityList/card_" + cardID);
        name = cardEntity.name;
        hp = cardEntity.hp;
        level = cardEntity.level;
        timecost = cardEntity.timecost;
        icon = cardEntity.icon;
    }

    public void OnDamage(int value)
    {
        Debug.Log("Damage");
        hp -= value;
    }
}
