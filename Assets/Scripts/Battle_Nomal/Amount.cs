using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Amount : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI amountUI;
    [SerializeField] int amountMoney;
    public int AmountMoney
    {
        get
        {
            return this.amountMoney;
        }
    }
    void TextAmount()
    {
        amountUI.text = AmountMoney.ToString();
    }
    private void Start()
    {
        TextAmount();
    }
}
