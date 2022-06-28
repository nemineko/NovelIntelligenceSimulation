using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralView : MonoBehaviour
{
    [SerializeField] Image iconImage;
    public void Show(GeneralModel generalModel)
    {
        iconImage.sprite = generalModel.icon;
    }
}
