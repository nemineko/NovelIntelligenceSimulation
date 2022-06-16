using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralMovement : MonoBehaviour
{
    [SerializeField] Transform defaultParent;
    Vector2 vector2;
    GeneralModel generalModel;
    float generalSPD;
    int generalATK;
    new Rigidbody2D rigidbody;
    Transform general;
    Transform generalflag;
    public void Start()
    {
        general = GetComponent<Transform>();
        generalSPD = generalModel.spd;
        generalATK = generalModel.atk;
        rigidbody = GetComponent<Rigidbody2D>();
        
        Debug.Log("vector2" + vector2);
        Debug.Log("general" + general);
        Debug.Log("generalSPD" + generalSPD);

    }
    void Update()
    {
        vector2 = generalflag.position - general.position;  //旗への方向を計算
        rigidbody.AddForce(vector2 * generalATK);//押し出す力の設定
        transform.Translate(1, 0, 0);//動くかどうかテスト
    }
    public void SetGeneralTransform(Transform parentTransform)
    {
        defaultParent = parentTransform;
        transform.SetParent(defaultParent);
    }
}
