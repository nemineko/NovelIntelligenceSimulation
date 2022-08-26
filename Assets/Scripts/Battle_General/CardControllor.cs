using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControllor : MonoBehaviour
{
    CardView cardview;//手札の見かけに関すること
    BaseCardModel model;//データ（モデル）に関すること
    bool playerDeck;
    public BaseCardModel Model { get => model; }
    public bool PlayerDeck { get => playerDeck; }
    private void Awake()
    {
        cardview = GetComponent<CardView>();
    }
    public void Init(int cardID)
    {
        model = new BaseCardModel(cardID);
        cardview.Show(model);
        playerDeck = model.player;
    }
}
