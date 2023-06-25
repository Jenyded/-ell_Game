using System.Collections.Generic;
using UnityEngine;

public class LevelsData
{
    private static int _curentLevel = 0;
    public static int CurentLevel { get => _curentLevel; set => _curentLevel = value; }

    public static readonly List<LevelData> Levels = new();

    public static int GetCurentLevel()
    {
        return _curentLevel;
    }

    public static LevelData GetCurrentLevel()
    {
        if (Levels.Count <= _curentLevel)
        {
            _curentLevel = Levels.Count - 1;
        }
        return Levels[_curentLevel];
    }

    public static void Init()
    {
        var allEnemyInfo = Resources.Load<EnemyInfo>("EnemyInfo");
        var allLevelBackgroundInfo = Resources.Load<LevelInfo>("LevelInfo");

        var level1 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("Background1"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyA"),
            IntervalCreationBonus = 1.5f,
            IntervalCreationLife = 8.2f,
            IntervalCreationShield = 31.0f,
            IntervalCreationEnemy = 1.0f,
            IntervalCreationLevelKey = 40.0f,
            FallSpeedBonus = 3.0f,
            FallSpeedLife = 3.0f,
            FallSpeedShield = 3.0f,
            FallSpeedEnemy = 3.0f,
            FallSpeedLevelKey = 3.0f
        };

        var level2 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("Background2"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyB"),
            IntervalCreationBonus = 2.0f,
            IntervalCreationLife = 9.4f,
            IntervalCreationShield = 30.2f,
            IntervalCreationEnemy = 0.9f,
            IntervalCreationLevelKey =75.0f,
            FallSpeedBonus = 4.0f,
            FallSpeedLife = 4.0f,
            FallSpeedShield = 4.0f,
            FallSpeedEnemy = 4.0f,
            FallSpeedLevelKey = 4.0f
        };

        var level3 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("Background3"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyC"),
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 7.4f,
            IntervalCreationShield = 29.1f,
            IntervalCreationEnemy = 1.0f,
            IntervalCreationLevelKey = 86.0f,
            FallSpeedBonus = 5.0f,
            FallSpeedLife = 5.0f,
            FallSpeedShield = 5.0f,
            FallSpeedEnemy = 5.0f,
            FallSpeedLevelKey = 5.0f
        };

        var level4 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("Background4"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyD"),
            IntervalCreationBonus = 2.0f,
            IntervalCreationLife = 8.1f,
            IntervalCreationShield = 26.1f,
            IntervalCreationEnemy = 1.0f,
            IntervalCreationLevelKey = 92.0f,
            FallSpeedBonus = 4.0f,
            FallSpeedLife = 4.0f,
            FallSpeedShield = 4.0f,
            FallSpeedEnemy = 4.0f,
            FallSpeedLevelKey = 4.0f
        };

        var level5 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("Background5"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyE"),
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 8.9f,
            IntervalCreationShield = 18.1f,
            IntervalCreationEnemy = 1.0f,
            IntervalCreationLevelKey = 98.0f,
            FallSpeedBonus = 5.1f,
            FallSpeedLife = 5.1f,
            FallSpeedShield = 5.1f,
            FallSpeedEnemy = 5.1f,
            FallSpeedLevelKey = 5.1f
        };

        var level6 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("Background6"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyF"),
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 8.4f,
            IntervalCreationShield = 26.1f,
            IntervalCreationEnemy = 1.0f,
            IntervalCreationLevelKey = 110.0f,
            FallSpeedBonus = 5.2f,
            FallSpeedLife = 5.2f,
            FallSpeedShield = 5.2f,
            FallSpeedEnemy = 5.2f,
            FallSpeedLevelKey = 5.0f
        };

        var level7 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("Background7"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyG"),
            IntervalCreationBonus = 1.5f,
            IntervalCreationLife = 9.4f,
            IntervalCreationShield = 17.1f,
            IntervalCreationEnemy = 1.0f,
            IntervalCreationLevelKey = 120.0f,
            FallSpeedBonus = 5.0f,
            FallSpeedLife = 5.0f,
            FallSpeedShield = 5.0f,
            FallSpeedEnemy = 5.0f,
            FallSpeedLevelKey = 5.0f
        };

        var level8 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("Background8"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyH"),
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 8.5f,
            IntervalCreationShield = 25.1f,
            IntervalCreationEnemy = 1.0f,
            IntervalCreationLevelKey = 105.0f,
            FallSpeedBonus = 5.0f,
            FallSpeedLife = 5.0f,
            FallSpeedShield = 5.0f,
            FallSpeedEnemy = 5.0f,
            FallSpeedLevelKey = 5.0f
        };

        var level9 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("Background9"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyI"),
            IntervalCreationBonus = 1.9f,
            IntervalCreationLife = 10.4f,
            IntervalCreationShield = 18.1f,
            IntervalCreationEnemy = 1.0f,
            IntervalCreationLevelKey = 140.0f,
            FallSpeedBonus = 5.0f,
            FallSpeedLife = 5.0f,
            FallSpeedShield = 5.0f,
            FallSpeedEnemy = 5.0f,
            FallSpeedLevelKey = 5.0f
        };

        var level10 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("Background10"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyJ"),
            IntervalCreationBonus = 2.1f,
            IntervalCreationLife = 9.5f,
            IntervalCreationShield = 20.1f,
            IntervalCreationEnemy = 0.9f,
            IntervalCreationLevelKey = 165.0f,
            FallSpeedBonus = 5.0f,
            FallSpeedLife = 5.0f,
            FallSpeedShield = 5.0f,
            FallSpeedEnemy = 5.0f,
            FallSpeedLevelKey = 5.0f
        };

        Levels.Add(level1);
        Levels.Add(level2);
        Levels.Add(level3);
        Levels.Add(level4);
        Levels.Add(level5);
        Levels.Add(level6);
        Levels.Add(level7);
        Levels.Add(level8);
        Levels.Add(level9);
        Levels.Add(level10);
    }   
}
