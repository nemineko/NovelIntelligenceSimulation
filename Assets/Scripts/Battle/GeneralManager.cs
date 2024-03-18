using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GeneralManager : MonoBehaviour
{
    [SerializeField] Transform ground;
    [SerializeField] Transform P_Transform;
    [SerializeField] Transform E_Transform;
    [SerializeField] Transform P_Flag;
    [SerializeField] Transform E_Flag;
    [SerializeField] GameObject generalPrefab;
    private GeneralList generalList;


    void Awake()
    {
        generalList = Resources.Load<GeneralList>(typeof(GeneralList).Name);

    }
    private void Start()
    {
        CreatePlayerGeneral(generalPrefab, generalList);
        CreateEnemyGeneral(generalPrefab, generalList);

    }
    void CreatePlayerGeneral(GameObject generalPrefab, GeneralList generalList)
    {
        foreach (GeneralEntity generalType in generalList.playerGeneralList)
        {
            Transform playerGeneralTransform = Instantiate(generalPrefab.transform, P_Transform);
            playerGeneralTransform.Find("Icon").GetComponent<Image>().sprite = generalType.icon;

            GeneralMovement.Instance.Inut(generalType, P_Flag);

        }

    }
    void CreateEnemyGeneral(GameObject generalPrefab, GeneralList generalList)
    {
        foreach (GeneralEntity generalType in generalList.enemyGeneralList)
        {
            Transform enemyGeneralTransform = Instantiate(generalPrefab.transform, E_Transform);
            enemyGeneralTransform.Find("Icon").GetComponent<Image>().sprite = generalType.icon;

            GeneralMovement.Instance.Inut(generalType, E_Flag);

        }
    }
}