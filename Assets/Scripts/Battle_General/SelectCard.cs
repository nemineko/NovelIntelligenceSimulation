using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCard : MonoBehaviour
{
    public void OnClick()
    {
        CardControllor cardControllor = GetComponent<CardControllor>();
        if (cardControllor.IsPlayer)
        {
            GameManager.instance.PlayerUnitOnField(cardControllor.Model);

        }
        else
        {
            GameManager.instance.EnemyUnitOnField(cardControllor.Model);

        }
        Debug.Log("クリックされたよ");
        //手札カードをクリックしたら、どのカードをクリックしたか取得
        //"UnitDeck"の配列に生成されるユニットを登録する
        //配列にユニットが登録されたらフィールドに該当ユニットを出現させる
    }
}
