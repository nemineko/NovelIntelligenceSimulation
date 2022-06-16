using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControllor : MonoBehaviour
{
    CardView cardview;//手札の見かけに関すること
    CardModel model;//データ（モデル）に関すること

    private void Awake()
    {
        cardview = GetComponent<CardView>();
    }
    public void Init(int cardID)
    {
        model = new CardModel(cardID);
        cardview.Show(model);
    }
}
