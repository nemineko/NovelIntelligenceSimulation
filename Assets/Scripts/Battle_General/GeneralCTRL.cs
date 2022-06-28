using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralCTRL : MonoBehaviour
{
    GeneralView generalView;//ユニットの見かけに関すること
    GeneralModel generalModel;//データ（モデル）に関すること
    GeneralMovement generalMovement;
    private void Awake()
    {
        generalView = GetComponent<GeneralView>();
        generalMovement = GetComponent<GeneralMovement>();
    }
    public void Init( int generalID, Transform flag)
    {
        generalModel = new GeneralModel(generalID);
        generalMovement.Inut(generalModel, flag);
        generalView.Show(generalModel);
    }
}
