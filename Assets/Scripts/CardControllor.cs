using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControllor : MonoBehaviour
{
    CardView cardview;
    UnitView unitview;
    CardModel model;

    private void Awake()
    {
        cardview = GetComponent<CardView>();
        unitview = GetComponent<UnitView>();
    }
    public void Init(int cardID)
    {
        model = new CardModel();
        cardview.Show(model);
        unitview.Show(model);
    }
}
