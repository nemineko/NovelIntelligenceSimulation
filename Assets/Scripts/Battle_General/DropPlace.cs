using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropPlace : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        UnitMovement unit = eventData.pointerDrag.GetComponent<UnitMovement>();
        if (unit != null)
        {
            //unit.defaultParent = this.transform;
            //���j�b�g�̏����擾����
            //������ނ̃��j�b�g���d�Ȃ�����
            ///1: 2�̃��j�b�g������
            ///2: �V�������x���A�b�v�������j�b�g���o��������
        }

    }
}
