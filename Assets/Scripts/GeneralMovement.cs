using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralMovement : MonoBehaviour
{
    [SerializeField] Transform defaultParent;
    Vector2 vector2;
    float generalSPD;
    float generalATK;
    new Rigidbody2D rigidbody;
    int generalID;
    Transform generalflag;
    public void Inut(GeneralModel generalModel, Transform flag)
    {
        generalflag = flag;
        generalSPD = generalModel.spd;
        generalATK = generalModel.atk;
        generalID = generalModel.id;
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        vector2 = transform.position - generalflag.position;  //旗への方向を計算
        rigidbody.AddForce(vector2 * generalATK);//押し出す力の設定
    }
    public void SetGeneralTransform(Transform parentTransform)
    {
        defaultParent = parentTransform;
        transform.SetParent(defaultParent);
    }
}
