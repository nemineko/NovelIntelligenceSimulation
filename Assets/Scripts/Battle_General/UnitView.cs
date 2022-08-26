using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitView : MonoBehaviour
{
    [SerializeField] Text hpText;
    [SerializeField] Text levelText;
    [SerializeField] Image iconImage;

    public void Show(BaseCardModel baseModel)
    {
        hpText.text = baseModel.hp.ToString();
        levelText.text = baseModel.level.ToString();
        iconImage.sprite = baseModel.icon;
    }
}
