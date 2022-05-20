using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform playerHandTransform, enemyHandTransform;
    [SerializeField] CardControllor cardPrefab;
    [SerializeField] Transform playerUnitTransform, enemyUnitTransform;
    [SerializeField] CardControllor unitPrefab;

    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        SettingInutHand();
    }

    void SettingInutHand()
    {
        for (int i = 0; i < 4; i++)
        {
            CreateCard(playerHandTransform);
            CreateCard(enemyHandTransform);
        }
    }

    void CreateCard(Transform hand)
    {
        CardControllor card = Instantiate(cardPrefab, hand,false);
    }

    public static GameManager instance;
    public void UnitOnField()
    {
        CreateUnit(playerUnitTransform);
    }

    public void CreateUnit(Transform unit)
    {
        CardControllor card = Instantiate(unitPrefab, unit, false);
    }
}