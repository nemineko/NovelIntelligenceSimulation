using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropPlace : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        UnitMovement unit = eventData.pointerDrag.GetComponent<UnitMovement>();
        if (unit != null)
        {
            //unit.defaultParent = this.transform;
            //ユニットの情報を取得する
            //同じ種類のユニットが重なったら
            ///1: 2つのユニットを消す
            ///2: 新しくレベルアップしたユニットを出現させる
        }

    }
}
