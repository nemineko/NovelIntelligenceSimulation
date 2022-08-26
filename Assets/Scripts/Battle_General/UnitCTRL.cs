using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCTRL : MonoBehaviour
{
    UnitView unitview;//ユニットの見かけに関すること
    BaseCardModel model;//データ（モデル）に関すること
    public UnitMovement movement;
    private void Awake()
    {
        unitview = GetComponent<UnitView>();
        movement = GetComponent<UnitMovement>();
    }
    public void Init(BaseCardModel baseModel)
    {
        int unitID = baseModel.id;
        model = new BaseCardModel(unitID);
        Debug.Log(baseModel);
        unitview.Show(model);
    }
}
