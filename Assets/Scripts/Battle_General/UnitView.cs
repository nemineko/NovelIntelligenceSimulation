using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitView : MonoBehaviour
{
    [SerializeField] Text hpText;
    [SerializeField] Text levelText;
    [SerializeField] Image iconImage;

    public void Show(PlayerCardModel cardModel)
    {
        hpText.text = cardModel.hp.ToString();
        levelText.text = cardModel.level.ToString();
        iconImage.sprite = cardModel.icon;
    }
}
