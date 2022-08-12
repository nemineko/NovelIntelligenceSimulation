using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    [SerializeField] Text timecostText;
    [SerializeField] Image iconImage;

    public void Show(PlayerCardModel cardModel)
    {
        timecostText.text = cardModel.timecost.ToString();
        iconImage.sprite = cardModel.icon;
    }
}
