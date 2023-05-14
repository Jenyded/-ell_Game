using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private CreatingObject CreatingObject;
    [SerializeField] private BackgroundGame backgroundGame;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    private void Start()
    {
        LevelsData.Init();
        CreatingObject.Init(LevelsData.Levels[0]);
        backgroundGame.Init(LevelsData.Levels[LevelsData.CurentLevel]);
    }

    public void SwitchLevel()
    {
        if (LevelsData.CurentLevel >= 10)
        {
            LevelsData.CurentLevel = 1;
        }
        else
        {
            LevelsData.CurentLevel++;
        }               
    }
}
