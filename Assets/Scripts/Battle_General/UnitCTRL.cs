using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCTRL : MonoBehaviour
{
    UnitView unitview;//���j�b�g�̌������Ɋւ��邱��
    BaseCardModel model;//�f�[�^�i���f���j�Ɋւ��邱��
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
