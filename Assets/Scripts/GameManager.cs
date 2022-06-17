using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform playerHandTransform, enemyHandTransform;
    [SerializeField] CardControllor cardPrefab;
    [SerializeField] Transform playerUnitTransform, enemyUnitTransform;
    [SerializeField] UnitCTRL unitPrefab;
    [SerializeField] Transform playerGeneralTransform, enemyGeneralTransform;
    [SerializeField] GeneralCTRL generalPrefab;
    [SerializeField] Transform playerFlag;
    [SerializeField] Transform enemyFlag;

    int playerGeneral = 1;
    int enemyGeneral = 2;

    public static GameManager instance;
    GeneralMovement generalMovement;
    UnitDeck unitDeck;
    CardDeck cardDeck;

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
        SettingPlayerInutHand();
        SettingEnemyInutHand();
        SettingGeneral();
    }
   
    //大将
    void SettingGeneral()
    {
        GiveGeneral(playerGeneralTransform, playerGeneral);
        GiveGeneral(enemyGeneralTransform, enemyGeneral);

    }
    void GiveGeneral(Transform ground, int generalID)
    {
        CreateGeneral(ground, generalID);
    }
    void CreateGeneral(Transform ground, int generalID)
    {
        GeneralCTRL general = Instantiate(generalPrefab, ground, false);
        general.Init(generalID);
    }

    //カード（手札）
    void SettingPlayerInutHand()
    {
        //↓この行がおかしい
        List<int> deck = cardDeck.playerDeck;
        for (int i = 0; i < deck.Count; i++)
        {
           Debug.Log(deck);
           GiveCardToHand(deck, playerHandTransform, i);
        }
    }
    void SettingEnemyInutHand()
    {
        //↓この行がおかしい
        List<int> deck = cardDeck.enemyDeck;
        for (int i = 0; i < deck.Count; i++)
        {
            GiveCardToHand(deck, enemyHandTransform, i);
        }
    }
    void GiveCardToHand(List<int> deck, Transform hand, int i)
    {
        if(deck == null)
        {
            return;
        }
        Debug.Log(deck);
        int cardID = deck[i];
        CreateCard(cardID, hand);
    }
    void CreateCard(int cardID, Transform hand)
    {
        CardControllor card = Instantiate(cardPrefab, hand, false);
        card.Init(cardID);
    }
 　　//ユニット（フィールドに出た駒）
    public void PlayerUnitOnField(int cardID)
    {
        CreateUnit(cardID, playerUnitTransform);
    }
    void EnemyUnitOnField(int cardID)
    {
        CreateUnit(cardID,enemyUnitTransform);
    }
    void CreateUnit(int cardID ,Transform unitParent)
    {
        UnitCTRL unit = Instantiate(unitPrefab, unitParent, false);
        unit.Init(cardID);
    }
}