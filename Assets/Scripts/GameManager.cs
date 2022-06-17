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

    UnitDeck unitDeck;
    CardDeck cardDeck;
    GeneralDeck generalDeck;

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
        cardDeck = GetComponent<CardDeck>();
        generalDeck = GetComponent<GeneralDeck>();
        SettingPlayerInutHand();
        SettingEnemyInutHand();
        SettingGeneral();
    }
   
    //大将
    void SettingGeneral()
    {
        int playerGeneral = generalDeck.playerGeneral;
        int enemyGeneral = generalDeck.enemyGeneral;
        GiveGeneral(playerGeneralTransform, playerGeneral, playerFlag);
        GiveGeneral(enemyGeneralTransform, enemyGeneral, enemyFlag);
    }
    void GiveGeneral(Transform ground, int generalID, Transform flag)
    {
        CreateGeneral(ground, generalID, flag);
    }
    void CreateGeneral(Transform ground, int generalID, Transform flag)
    {
        GeneralCTRL general = Instantiate(generalPrefab, ground, false);
        general.Init(generalID, flag);
    }

    //カード（手札）
    void SettingPlayerInutHand()
    {
        List<int> deck = cardDeck.playerDeck;
        for (int i = 0; i < deck.Count; i++)
        {
           Debug.Log(deck);
           GiveCardToHand(deck, playerHandTransform, i);
        }
    }
    void SettingEnemyInutHand()
    {
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
    public void PlayerUnitOnField(CardModel cardModel)
    {
        CreateUnit(cardModel, playerUnitTransform);
    }
    void EnemyUnitOnField(CardModel cardModel)
    {
        //CreateUnit(cardModel, enemyUnitTransform);
    }
    void CreateUnit(CardModel cardModel, Transform unitParent)
    {
        UnitCTRL unit = Instantiate(unitPrefab, unitParent, false);
        unit.Init(cardModel);
    }
}