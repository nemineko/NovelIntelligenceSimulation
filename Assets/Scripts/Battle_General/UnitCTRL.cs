using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCTRL : MonoBehaviour
{
    UnitView unitview;//���j�b�g�̌������Ɋւ��邱��
    CardModel model;//�f�[�^�i���f���j�Ɋւ��邱��
    public CardMovement movement;
    private void Awake()
    {
        unitview = GetComponent<UnitView>();
        movement = GetComponent<CardMovement>();
    }
    public void Init(CardModel cardModel)
    {
        int unitID = cardModel.id;
        model = new CardModel(unitID);
        unitview.Show(model);
    }
}