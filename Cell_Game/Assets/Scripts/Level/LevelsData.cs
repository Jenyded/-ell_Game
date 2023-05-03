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
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("BackgroundBlue"),
            EnemyObj = allEnemyInfo.GetGameObj("Enemy"),
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 6.4f,
            IntervalCreationShield = 12.1f,
            IntervalCreationEnemy = 1f,
            IntervalCreationLevelKey = 7.1f,
            FallSpeedBonus = 3,
            FallSpeedLife = 3,
            FallSpeedShield = 3,
            FallSpeedEnemy = 3,
            FallSpeedLevelKey = 3
        };

        var level2 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("BackgroundGrey"),
            EnemyObj = allEnemyInfo.GetGameObj("Enemy2"),
            IntervalCreationBonus = 2f,
            IntervalCreationLife = 6.4f,
            IntervalCreationShield = 12.1f,
            IntervalCreationEnemy = 0.9f,
            IntervalCreationLevelKey = 16f,
            FallSpeedBonus = 4,
            FallSpeedLife = 4,
            FallSpeedShield = 4,
            FallSpeedEnemy = 4,
            FallSpeedLevelKey = 4
        };

        var level3 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("BackgroundBlack"),
            EnemyObj = allEnemyInfo.GetGameObj("Enemy3"),
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 6.4f,
            IntervalCreationShield = 12.1f,
            IntervalCreationEnemy = 1f,
            IntervalCreationLevelKey = 15f,
            FallSpeedBonus = 5,
            FallSpeedLife = 5,
            FallSpeedShield = 5,
            FallSpeedEnemy = 5,
            FallSpeedLevelKey = 5
        };

        var level4 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("BackgroundGrey"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyP"),
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 6.4f,
            IntervalCreationShield = 12.1f,
            IntervalCreationEnemy = 1f,
            IntervalCreationLevelKey = 14f,
            FallSpeedBonus = 5,
            FallSpeedLife = 5,
            FallSpeedShield = 5,
            FallSpeedEnemy = 5,
            FallSpeedLevelKey = 5
        };

        var level5 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("BackgroundGrey"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyPJ"),
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 6.4f,
            IntervalCreationShield = 12.1f,
            IntervalCreationEnemy = 1f,
            IntervalCreationLevelKey = 12f,
            FallSpeedBonus = 5,
            FallSpeedLife = 5,
            FallSpeedShield = 5,
            FallSpeedEnemy = 5,
            FallSpeedLevelKey = 5
        };

        var level6 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("BackgroundGrey"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyUV"),
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 6.4f,
            IntervalCreationShield = 12.1f,
            IntervalCreationEnemy = 1f,
            IntervalCreationLevelKey = 10f,
            FallSpeedBonus = 5,
            FallSpeedLife = 5,
            FallSpeedShield = 5,
            FallSpeedEnemy = 5,
            FallSpeedLevelKey = 5
        };

        var level7 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("BackgroundGrey"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyY"),
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 6.4f,
            IntervalCreationShield = 12.1f,
            IntervalCreationEnemy = 1f,
            IntervalCreationLevelKey = 9f,
            FallSpeedBonus = 5,
            FallSpeedLife = 5,
            FallSpeedShield = 5,
            FallSpeedEnemy = 5,
            FallSpeedLevelKey = 5
        };

        var level8 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("BackgroundGrey"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyYR"),
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 6.4f,
            IntervalCreationShield = 12.1f,
            IntervalCreationEnemy = 1f,
            IntervalCreationLevelKey = 12f,
            FallSpeedBonus = 5,
            FallSpeedLife = 5,
            FallSpeedShield = 5,
            FallSpeedEnemy = 5,
            FallSpeedLevelKey = 5
        };

        var level9 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("BackgroundGrey"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyYT"),
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 6.4f,
            IntervalCreationShield = 12.1f,
            IntervalCreationEnemy = 1f,
            IntervalCreationLevelKey = 14f,
            FallSpeedBonus = 5,
            FallSpeedLife = 5,
            FallSpeedShield = 5,
            FallSpeedEnemy = 5,
            FallSpeedLevelKey = 5
        };

        var level10 = new LevelData
        {
            LevelBackgroundGame = allLevelBackgroundInfo.GetLevel("BackgroundGrey"),
            EnemyObj = allEnemyInfo.GetGameObj("EnemyZ"),
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 6.4f,
            IntervalCreationShield = 12.1f,
            IntervalCreationEnemy = 1f,
            IntervalCreationLevelKey = 16f,
            FallSpeedBonus = 5,
            FallSpeedLife = 5,
            FallSpeedShield = 5,
            FallSpeedEnemy = 5,
            FallSpeedLevelKey = 5
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

    //public static void SwitchLevel()
    //{
    //    ++_curentLevel;
    //}

}
