using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControllor : MonoBehaviour
{
    CardView cardview;//手札の見かけに関すること
    PlayerCardModel model;//データ（モデル）に関すること
    bool isPlayer;//プレイヤーターンか否か
    public PlayerCardModel Model { get => model; }
    public bool IsPlayer { get => isPlayer; }
    private void Awake()
    {
        cardview = GetComponent<CardView>();
    }
    public void Init(int cardID, bool isPlayer)
    {
        model = new PlayerCardModel(cardID);
        cardview.Show(model);
        this.isPlayer = isPlayer;
    }
}
