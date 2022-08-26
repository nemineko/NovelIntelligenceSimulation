using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControllor : MonoBehaviour
{
    CardView cardview;//��D�̌������Ɋւ��邱��
    BaseCardModel model;//�f�[�^�i���f���j�Ɋւ��邱��
    bool playerDeck;
    public BaseCardModel Model { get => model; }
    public bool PlayerDeck { get => playerDeck; }
    private void Awake()
    {
        cardview = GetComponent<CardView>();
    }
    public void Init(int cardID)
    {
        model = new BaseCardModel(cardID);
        cardview.Show(model);
        playerDeck = model.player;
    }
}
