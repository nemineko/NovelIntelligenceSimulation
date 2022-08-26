using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCard : MonoBehaviour
{
    public void OnClick()
    {
        CardControllor cardControllor = GetComponent<CardControllor>();
        if (cardControllor.PlayerDeck == true)
        {
            GameManager.instance.PlayerUnitOnField(cardControllor.Model);
            Debug.Log("PlayerDeck");


        }
        else
        {
            GameManager.instance.EnemyUnitOnField(cardControllor.Model);
            Debug.Log("EnemyDeck");

        }
    }
}
