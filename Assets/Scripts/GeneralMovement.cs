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

    // •¨—‰‰Z‚ğ‚µ‚½‚¢ê‡‚ÍFixedUpdate‚ğg‚¤‚Ì‚ªˆê”Ê“I
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
