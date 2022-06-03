using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralMovement : MonoBehaviour
{
    [SerializeField] Transform defaultParent;
    private new Rigidbody2D rigidbody;
    public GeneralModel playerGeneralATK;
    public GeneralModel enemyGeneralATK;
    public GeneralModel playerGeneralDEF;
    public GeneralModel enemyGeneralDEF;

    // 物理演算をしたい場合はFixedUpdateを使うのが一般的
    void Update()
    {
        Vector2 position = transform.position;


    }
    public void SetGeneralTransform(Transform parentTransform)
    {
        defaultParent = parentTransform;
        transform.SetParent(defaultParent);
    }
}
