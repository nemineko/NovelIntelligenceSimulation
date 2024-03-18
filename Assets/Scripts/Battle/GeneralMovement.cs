using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralMovement : MonoBehaviour
{
    public static GeneralMovement Instance { get; private set; }


    Vector2 vector2;
    float generalSPD;
    float generalSTM;
    float generalATK;
    new Rigidbody2D rigidbody;
    int generalID;
    bool isPush;

    private void Awake()
    {
        Instance = this;
    }
    public void Inut(GeneralEntity generalEntity, Transform flag)
    {
        generalSPD = generalEntity.spd;
        generalSTM = generalEntity.stm;
        generalATK = generalEntity.atk;
        generalID = generalEntity.id;
        rigidbody = GetComponent<Rigidbody2D>();
        StartCoroutine(UpdateMove(flag));
    }
    IEnumerator UpdateMove(Transform flag)
    {
        while (true)
        {
            isPush = true;
            StartCoroutine(UpdateAttack(flag));
            yield return new WaitForSeconds(generalSTM);
            isPush = false;
            yield return new WaitForSeconds(generalSTM);
        }
    }
    IEnumerator UpdateAttack(Transform flag)
    {
        if (isPush == true)
        {
            vector2 = transform.position - flag.position;  //旗への方向を計算
            rigidbody.AddForce(vector2 * generalATK);//押し出す力の設定
            yield return new WaitForSeconds(generalSPD * 0.5f);
        }
        else if(isPush == false)
        {
            rigidbody.velocity = Vector3.zero;
            yield break;
        }
    }
}
