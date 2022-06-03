using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateUnit : MonoBehaviour
{
    // public GameManager cardClick;
    public void OnClick()
    {
        Debug.Log("OnClick");
        // cardClick.CardClick();
        GameManager.instance.CardClick();
    }
}
