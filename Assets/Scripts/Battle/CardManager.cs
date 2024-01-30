using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardManager : MonoBehaviour
{
    private Dictionary<BaseCardEntity, Transform> cardTransformDictionary;
    private CardList cardList;
    private UnitList unitList;
    [SerializeField] private UnitCTRL unitPrefab;
    [SerializeField] private Transform p_Hand;
    [SerializeField] private Transform e_Hand;
    [SerializeField] private Transform p_Unit;
    [SerializeField] private Transform e_Unit;

    private void Awake()
    {
        cardTransformDictionary = new Dictionary<BaseCardEntity, Transform>();
        unitList = Resources.Load<UnitList>(typeof(UnitList).Name);

        PlayerCardCreate();
        EnemyCardCreate();
    }



    //場にプレーヤーの手札を表示する
    private void PlayerCardCreate()
    {
        this.gameObject.SetActive(false);

        cardList = Resources.Load<CardList>(typeof(CardList).Name);


        foreach (BaseCardEntity cardType in cardList.playerCardList)
        {
            Transform playerCardTransform = Instantiate(this.transform, p_Hand);
            playerCardTransform.gameObject.SetActive(true);


            playerCardTransform.Find("Icon").GetComponent<Image>().sprite = cardType.playerIcon;

            playerCardTransform.GetComponent<Button>().onClick.AddListener(() =>
            {
                PlayerUnitOnField(unitPrefab, cardType, p_Unit);
            });

            cardTransformDictionary[cardType] = playerCardTransform;

        }
    }

    //場にエネミーの手札を表示する
    private void EnemyCardCreate()
    {
        this.gameObject.SetActive(false);



        foreach (BaseCardEntity cardType in cardList.enemyCardList)
        {
            Transform enemyCardTransform = Instantiate(this.transform, e_Hand);
            enemyCardTransform.gameObject.SetActive(true);



            enemyCardTransform.Find("Icon").GetComponent<Image>().sprite = cardType.enemyIcon;

            enemyCardTransform.GetComponent<Button>().onClick.AddListener(() =>
            {
                EnemyUnitOnField(unitPrefab, cardType, e_Unit);
            });

            cardTransformDictionary[cardType] = enemyCardTransform;

        }
    }

    public void PlayerUnitOnField(UnitCTRL unitPrefab, BaseCardEntity cardType, Transform p_Unit)
    {

        //場に出したUnitの数が9を超えたら、場にUnitを出さないようにする
        if (unitList.playerUnitList.Count < 9)
        {
            Transform unitTransform = Instantiate(unitPrefab.transform, p_Unit);
            //Debug.Log("cardType.level:" + cardType.level+ "cardType.hp:" + cardType.hp);

            //データに合わせてプレハブの見た目を変える
            unitTransform.Find("Icon").GetComponent<Image>().sprite = cardType.playerIcon;
            unitTransform.Find("Level").GetComponent<Text>().text = cardType.level.ToString();
            unitTransform.Find("HP").GetComponent<Text>().text = cardType.hp.ToString();


            //ScriptableObject:UnitListに、場に出したUnitの情報を追加
            unitList.playerUnitList.Add(cardType);
        }
    }
    public void EnemyUnitOnField(UnitCTRL unitPrefab, BaseCardEntity cardType, Transform e_Unit)
    {
        //場に出したUnitの数が9を超えたら、場にUnitを出さないようにする
        if (unitList.enemyUnitList.Count < 9)
        {
            Transform unitTransform = Instantiate(unitPrefab.transform, e_Unit);

            //データに合わせてプレハブの見た目を変える
            unitTransform.Find("Icon").GetComponent<Image>().sprite = cardType.enemyIcon;
            unitTransform.Find("Level").GetComponent<Text>().text = cardType.level.ToString();
            unitTransform.Find("HP").GetComponent<Text>().text = cardType.hp.ToString();


            //ScriptableObject:UnitListに、場に出したUnitの情報を追加
            unitList.enemyUnitList.Add(cardType);
        }
    }
}
