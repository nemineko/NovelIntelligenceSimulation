using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    [SerializeField] Text costText;
    [SerializeField] Image iconImage;

    public void Show(CardModel cardModel)
    {
        costText.text = cardModel.cost.ToString();
        iconImage.sprite = cardModel.icon;
    }
}
