using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform playerHandTransform, enemyHandTransform;
    [SerializeField] CardControllor cardPrefab;
    [SerializeField] Transform playerUnitTransform, enemyUnitTransform;
    [SerializeField] CardControllor unitPrefab;

    List<int> playerDeck = new List<int>() { 1,1,2,2 };
    List<int> enemyDeck = new List<int>() { 3,0,3,0 };
    public static GameManager unit;

    void Awake()
    {       
        if (unit == null)
        {
            unit = this;
        }
    }
    void Start()
    {
        StartGame();

    }
    void StartGame()
    {
        SettingInutHand();
    }

    void SettingInutHand()
    {
        for (int i = 0; i < 4; i++)
        {
            GiveCardToHand(playerDeck, playerHandTransform);
            GiveCardToHand(enemyDeck, enemyHandTransform);
        }
    }
    void GiveCardToHand(List<int> deck, Transform hand)
    {
        if(deck.Count == 0)
        {
            return;
        }
        int cardID = deck[0];
        deck.RemoveAt(0);
        CreateCard(cardID, hand);
    }
    void CreateCard(int cardID, Transform hand)
    {
        CardControllor card = Instantiate(cardPrefab, hand, false);
        card.Init(cardID);
    }
    public void CardClick()
    {
        if (cardPrefab == playerHandTransform)
        {
            PlayerCardClick();
        }
        else if (cardPrefab == enemyHandTransform)
        {
            EnemyCardClick();
        }
    }
    void PlayerCardClick()
    {
        CardControllor[] cardList = playerHandTransform.GetComponentsInChildren<CardControllor>();
        CardControllor card = cardList[0];
        card.movement.SetUnitTransform(playerUnitTransform);
        PlayerUnitOnField();
    }
    void EnemyCardClick()
    {
        CardControllor[] cardList = enemyHandTransform.GetComponentsInChildren<CardControllor>();
        CardControllor card = cardList[0];
        card.movement.SetUnitTransform(enemyUnitTransform);
        EnemyUnitOnField();
    }

    void PlayerUnitOnField()
    {
        CreateUnit(playerUnitTransform);
    }
    void EnemyUnitOnField()
    {
        CreateUnit(enemyUnitTransform);
    }
    void CreateUnit(Transform unitParent)
    {
        CardControllor unit = Instantiate(unitPrefab, unitParent, false);
    }
}