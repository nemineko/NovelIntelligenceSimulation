using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "CardList")]

public class CardList : ScriptableObject
{
    public List<BaseCardEntity> playerCardList;
    public List<BaseCardEntity> enemyCardList;
}
