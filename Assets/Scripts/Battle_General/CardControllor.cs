using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControllor : MonoBehaviour
{
    CardView cardview;//��D�̌������Ɋւ��邱��
    PlayerCardModel model;//�f�[�^�i���f���j�Ɋւ��邱��
    bool isPlayer;//�v���C���[�^�[�����ۂ�
    public PlayerCardModel Model { get => model; }
    public bool IsPlayer { get => isPlayer; }
    private void Awake()
    {
        cardview = GetComponent<CardView>();
    }
    public void Init(int cardID, bool isPlayer)
    {
        model = new PlayerCardModel(cardID);
        cardview.Show(model);
        this.isPlayer = isPlayer;
    }
}
