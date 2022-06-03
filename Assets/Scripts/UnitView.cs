using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitView : MonoBehaviour
{
    [SerializeField] Text hpText;
    [SerializeField] Text levelText;
    [SerializeField] Image iconImage;

    public void Show(CardModel cardModel)
    {
        cardModel.OnDamage(10);
        hpText.text = cardModel.Hp.ToString();
        levelText.text = cardModel.level.ToString();
        iconImage.sprite = cardModel.icon;
    }
}
