using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsData
{
    private static int _curentLevel = 0;
    public static readonly List<LevelData> Levels = new();

    public static int CurentLevel()
    {
        return _curentLevel;
    }

    public static void Init()
    {
        var level1 = new LevelData
        {
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
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 6.4f,
            IntervalCreationShield = 12.1f,
            IntervalCreationEnemy = 0.9f,
            IntervalCreationLevelKey = 20f,

            FallSpeedBonus = 4,
            FallSpeedLife = 4,
            FallSpeedShield = 4,
            FallSpeedEnemy = 4,
            FallSpeedLevelKey = 4
        };

        var level3 = new LevelData
        {
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 6.4f,
            IntervalCreationShield = 12.1f,
            IntervalCreationEnemy = 1f,
            IntervalCreationLevelKey = 20f,

            FallSpeedBonus = 5,
            FallSpeedLife = 5,
            FallSpeedShield = 5,
            FallSpeedEnemy = 5,
            FallSpeedLevelKey = 5
        };

        Levels.Add(level1);
        Levels.Add(level2);
        Levels.Add(level3);
    }

    public static void SwitchLevel()
    {
        ++_curentLevel;
    }

    public static LevelData GetCurrentLevel()
    {
        if (Levels.Count <= _curentLevel)
        {
            _curentLevel = Levels.Count - 1;            
        }
            return Levels[_curentLevel];
    }
}
