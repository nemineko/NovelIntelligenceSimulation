using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCTRL : MonoBehaviour
{
    UnitView unitview;//ユニットの見かけに関すること
    CardModel model;//データ（モデル）に関すること
    public CardMovement movement;
    private void Awake()
    {
        unitview = GetComponent<UnitView>();
        movement = GetComponent<CardMovement>();
    }
    public void Init(int cardID)
    {
        model = new CardModel(cardID);
        unitview.Show(model);
    }
}
