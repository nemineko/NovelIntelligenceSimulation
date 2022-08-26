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
    public List<int> playerDeck = new List<int>();
    public List<int> enemyDeck = new List<int>();
    public List<int> playerUnits = new List<int>();
    public List<int> enemyUnits = new List<int>();
    [SerializeField] int playerGeneral;
    [SerializeField] int enemyGeneral;

    int playerListI = 0;
    int enemyListI = 0;


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
        SettingPlayerInutHand();
        SettingEnemyInutHand();
        SettingGeneral();
    }

    #region �叫
    void SettingGeneral()
    {
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
    #endregion

    #region �J�[�h�i��D�j
    void SettingPlayerInutHand()
    {
        List<int> deck = playerDeck;
        for (int i = 0; i < deck.Count; i++)
        {
            GiveCardToHand(deck, playerHandTransform, i, true);
        }
    }
    void SettingEnemyInutHand()
    {
        List<int> deck = enemyDeck;
        for (int i = 0; i < deck.Count; i++)
        {
            GiveCardToHand(deck, enemyHandTransform, i, false);
        }
    }
    void GiveCardToHand(List<int> deck, Transform hand, int i, bool isPlayerTurn)
    {
        if(deck == null)
        {
            return;
        }
        int cardID = deck[i];
        CreateCard(cardID, hand, isPlayerTurn);
    }
    void CreateCard(int cardID, Transform hand, bool isPlayerTurn)
    {
        CardControllor card = Instantiate(cardPrefab, hand, isPlayerTurn);
        card.Init(cardID);
    }
    #endregion
    #region ���j�b�g�i�t�B�[���h�ɏo����j
    public void PlayerUnitOnField(BaseCardModel cardModel)
    {
        cardModel.player = true;
        CreatePlayerUnit(cardModel, playerUnitTransform);
        Debug.Log("PlayerUnitOnField");

    }
    public void EnemyUnitOnField(BaseCardModel cardModel)
    {
        cardModel.player = false;
        CreateEnemyUnit(cardModel, enemyUnitTransform);
        Debug.Log("EnemyUnitOnField");

    }
    void CreatePlayerUnit(BaseCardModel cardModel, Transform unitParent)
    {
        //���X�g"playerUnits"�̋�f�[�^�Ɏ���id�ԍ�(int�^)��ǉ�
        if(playerListI < 9)
        {
            if (playerUnits[playerListI] == 0)
            {
                UnitCTRL unit = Instantiate(unitPrefab, unitParent);
                unit.Init(cardModel);
                playerUnits[playerListI] = cardModel.id;
                playerListI++;
            }
        }
       
    }
    void CreateEnemyUnit(BaseCardModel cardModel, Transform unitParent)
    {
        //���X�g"enemyUnits"�̋�f�[�^�Ɏ���id�ԍ�(int�^)��ǉ�
        if (enemyListI < 9)
        {
            if (enemyUnits[enemyListI] == 0)
            {
                UnitCTRL unit = Instantiate(unitPrefab, unitParent);
                unit.Init(cardModel);
                enemyUnits[enemyListI] = cardModel.id;
                enemyListI++;
            }
        }
    }
    #endregion
}