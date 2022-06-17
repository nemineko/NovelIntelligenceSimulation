using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralCTRL : MonoBehaviour
{
    GeneralView generalView;//���j�b�g�̌������Ɋւ��邱��
    GeneralModel generalModel;//�f�[�^�i���f���j�Ɋւ��邱��
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
