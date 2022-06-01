using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControllor : MonoBehaviour
{
    CardView cardview;//��D�̌������Ɋւ��邱��
    UnitView unitview;//���j�b�g�̌������Ɋւ��邱��
    CardModel model;//�f�[�^�i���f���j�Ɋւ��邱��
    public CardMovement movement;

    private void Awake()
    {
        cardview = GetComponent<CardView>();
        unitview = GetComponent<UnitView>();
        movement = GetComponent<CardMovement>();
    }
    public void Init(int cardID)
    {
        model = new CardModel(cardID);
        cardview.Show(model);
        unitview.Show(model);
    }
}
