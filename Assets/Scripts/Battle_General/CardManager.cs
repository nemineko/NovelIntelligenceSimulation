using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardManager : MonoBehaviour
{
    private Dictionary<BaseCardEntity, Transform> cardTransformDictionary;
    private CardList cardList;
    [SerializeField] private CardCTRL cardTemplate;
    [SerializeField] private UnitCTRL unitPrefab;
    [SerializeField] private Transform p_Hand;
    [SerializeField] private Transform e_Hand;
    [SerializeField] private Transform p_Unit;
    [SerializeField] private Transform e_Unit;

    private void Awake()
    {
        cardTransformDictionary = new Dictionary<BaseCardEntity, Transform>();

        PlayerCardCreate();
        EnemyCardCreate();
    }

    private void PlayerCardCreate()
    {
        cardTemplate.gameObject.SetActive(false);

        cardList = Resources.Load<CardList>(typeof(CardList).Name);


        foreach (BaseCardEntity cardType in cardList.playerCardList)
        {
            Transform playerCardTransform = Instantiate(cardTemplate.transform, p_Hand);
            playerCardTransform.gameObject.SetActive(true);


            playerCardTransform.Find("Icon").GetComponent<Image>().sprite = cardType.playerIcon;

            playerCardTransform.GetComponent<Button>().onClick.AddListener(() =>
            {
                CardCTRL.Instance.PlayerUnitOnField(unitPrefab, cardType, p_Unit);
            });

            cardTransformDictionary[cardType] = playerCardTransform;

        }
    }

    private void EnemyCardCreate()
    {
        cardTemplate.gameObject.SetActive(false);



        foreach (BaseCardEntity cardType in cardList.enemyCardList)
        {
            Transform enemyCardTransform = Instantiate(cardTemplate.transform, e_Hand);
            enemyCardTransform.gameObject.SetActive(true);



            enemyCardTransform.Find("Icon").GetComponent<Image>().sprite = cardType.enemyIcon;

            enemyCardTransform.GetComponent<Button>().onClick.AddListener(() =>
            {
                CardCTRL.Instance.EnemyUnitOnField(unitPrefab, cardType, e_Unit);
            });

            cardTransformDictionary[cardType] = enemyCardTransform;

        }
    }
}
