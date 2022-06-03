using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform playerHandTransform, enemyHandTransform;
    [SerializeField] CardControllor cardPrefab;
    [SerializeField] Transform playerUnitTransform, enemyUnitTransform;
    [SerializeField] CardControllor unitPrefab;
    [SerializeField] Transform generalTransform;
    [SerializeField] GeneralCTRL generalPrefab;

    List<int> playerDeck = new List<int>() { 1,1,2,2 };
    List<int> enemyDeck = new List<int>() { 3,0,3,0 };

    int playerGeneral = 0;
    int enemyGeneral = 1;

    public static GameManager instance;

    void Awake()
    {       
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        StartGame();

    }
    void StartGame()
    {
        SettingInutHand();
        SettingGeneral();
    }
    void SettingGeneral()
    {
        GiveGeneral(generalTransform, playerGeneral);
        GiveGeneral(generalTransform, enemyGeneral);
    }
    void GiveGeneral(Transform ground, int generalID)
    {
        CreateGeneral(ground, generalID);
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
    void CreateGeneral(Transform ground, int generalID)
    {
        GeneralCTRL general = Instantiate(generalPrefab, ground, false);
        general.Init(generalID);
    }
    void CreateCard(int cardID, Transform hand)
    {
        CardControllor card = Instantiate(cardPrefab, hand, false);
        card.Init(cardID);
    }
    public void CardClick()
    {
        if (cardPrefab.transform.position == playerHandTransform.position)
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