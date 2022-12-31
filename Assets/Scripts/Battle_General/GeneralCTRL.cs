using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralCTRL : MonoBehaviour
{
    private GeneralEntity generalType;


    public static GeneralCTRL Instance { get; private set; }
    void Awake()
    {
        Instance = this;

    }

   
}
