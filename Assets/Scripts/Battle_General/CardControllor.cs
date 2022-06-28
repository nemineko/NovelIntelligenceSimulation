using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControllor : MonoBehaviour
{
    CardView cardview;//��D�̌������Ɋւ��邱��
    CardModel model;//�f�[�^�i���f���j�Ɋւ��邱��

    private void Awake()
    {
        cardview = GetComponent<CardView>();
    }
    public void Init(int cardID)
    {
        model = new CardModel(cardID);
        cardview.Show(model);
    }
}
