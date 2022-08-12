using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCTRL : MonoBehaviour
{
    UnitView unitview;//���j�b�g�̌������Ɋւ��邱��
    PlayerCardModel playerModel;//�f�[�^�i���f���j�Ɋւ��邱��
    EnemyCardModel enemyModel;
    public CardMovement movement;
    private void Awake()
    {
        unitview = GetComponent<UnitView>();
        movement = GetComponent<CardMovement>();
    }
    public void PlayerInit(PlayerCardModel playerModel)
    {
        int unitID = playerModel.id;
        playerModel = new PlayerCardModel(unitID);
        unitview.Show(playerModel);
    }
    public void EnemyInit(EnemyCardModel enemyModel)
    {
        int unitID = enemyModel.id;
        enemyModel = new EnemyCardModel(unitID);
        unitview.Show(playerModel);
    }
}
