using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardCTRL: MonoBehaviour
{
    UnitList unitList;
    public static CardCTRL Instance { get; private set; }

    private void Awake()
    {
        Instance = this;

        unitList= Resources.Load<UnitList>(typeof(UnitList).Name);
    }

    public void PlayerUnitOnField(UnitCTRL unitPrefab, BaseCardEntity cardType, Transform p_Unit)
    {
        
        //��ɏo����Unit�̐���9�𒴂�����A���Unit���o���Ȃ��悤�ɂ���
        if (unitList.playerUnitList.Count < 9)
        {
            Transform unitTransform = Instantiate(unitPrefab.transform, p_Unit);
            //Debug.Log("cardType.level:" + cardType.level+ "cardType.hp:" + cardType.hp);

            //�f�[�^�ɍ��킹�ăv���n�u�̌����ڂ�ς���
            unitTransform.Find("Icon").GetComponent<Image>().sprite = cardType.playerIcon;
            unitTransform.Find("Level").GetComponent<Text>().text = cardType.level.ToString();
            unitTransform.Find("HP").GetComponent<Text>().text = cardType.hp.ToString();
            

            //ScriptableObject:UnitList�ɁA��ɏo����Unit�̏���ǉ�
            unitList.playerUnitList.Add(cardType);
        }
    }
    public void EnemyUnitOnField(UnitCTRL unitPrefab, BaseCardEntity cardType, Transform e_Unit)
    {
        //��ɏo����Unit�̐���9�𒴂�����A���Unit���o���Ȃ��悤�ɂ���
        if (unitList.enemyUnitList.Count < 9)
        {
            Transform unitTransform = Instantiate(unitPrefab.transform, e_Unit);

            //�f�[�^�ɍ��킹�ăv���n�u�̌����ڂ�ς���
            unitTransform.Find("Icon").GetComponent<Image>().sprite = cardType.enemyIcon;
            unitTransform.Find("Level").GetComponent<Text>().text = cardType.level.ToString();
            unitTransform.Find("HP").GetComponent<Text>().text = cardType.hp.ToString();
            

            //ScriptableObject:UnitList�ɁA��ɏo����Unit�̏���ǉ�
            unitList.enemyUnitList.Add(cardType);
        }
    }

}
