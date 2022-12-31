using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


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
        
        //場に出したUnitの数が9を超えたら、場にUnitを出さないようにする
        if (unitList.playerUnitList.Count < 9)
        {
            Transform unitTransform = Instantiate(unitPrefab.transform, p_Unit);

            //データに合わせてプレハブの見た目を変えたいが上手くいかない
            unitTransform.Find("Icon").GetComponent<Image>().sprite = cardType.playerIcon;
            /*
            unitTransform.Find("Level").GetComponent<TextMeshProUGUI>().text = cardType.level.ToString();
            unitTransform.Find("HP").GetComponent<TextMeshProUGUI>().text = cardType.hp.ToString();
            */

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

            //データに合わせてプレハブの見た目を変えたいが上手くいかない
            unitTransform.Find("Icon").GetComponent<Image>().sprite = cardType.enemyIcon;
            /*
             unitTransform.Find("Level").GetComponent<TextMeshProUGUI>().text = cardType.level.ToString();
            unitTransform.Find("HP").GetComponent<TextMeshProUGUI>().text = cardType.hp.ToString();
            */


            //ScriptableObject:UnitListに、場に出したUnitの情報を追加
            unitList.enemyUnitList.Add(cardType);
        }
    }

}
