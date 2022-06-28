using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralMovement : MonoBehaviour
{
    [SerializeField] Transform defaultParent;
    Vector2 vector2;
    float generalSPD;
    float generalSTM;
    float generalATK;
    new Rigidbody2D rigidbody;
    int generalID;
    Transform generalflag;
    bool isPush;
    public void Inut(GeneralModel generalModel, Transform flag)
    {
        generalflag = flag;
        generalSPD = generalModel.spd;
        generalSTM = generalModel.stm;
        generalATK = generalModel.atk;
        generalID = generalModel.id;
        rigidbody = GetComponent<Rigidbody2D>();
        StartCoroutine(UpdateMove());
    }
    IEnumerator UpdateMove()
    {
        while (true)
        {
            isPush = true;
            StartCoroutine(UpdateAttack());
            yield return new WaitForSeconds(generalSTM);
            isPush = false;
            yield return new WaitForSeconds(generalSTM);
        }
    }
    IEnumerator UpdateAttack()
    {
        if (isPush == true)
        {
            vector2 = transform.position - generalflag.position;  //旗への方向を計算
            rigidbody.AddForce(vector2 * generalATK);//押し出す力の設定
            yield return new WaitForSeconds(generalSPD * 0.5f);
        }
        else if(isPush == false)
        {
            rigidbody.velocity = Vector3.zero;
            yield break;
        }
    }
    public void SetGeneralTransform(Transform parentTransform)
    {
        defaultParent = parentTransform;
        transform.SetParent(defaultParent);
    }
}
