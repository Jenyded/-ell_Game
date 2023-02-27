using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsData : MonoBehaviour
{
    public static readonly List<LevelData> Levels = new();

    public void Init()
    {
        var level1 = new LevelData
        {
            IntervalCreationBonus = 1.8f,
            IntervalCreationLife = 6f,
            IntervalCreationShield = 12f,
            IntervalCreationEnemy = 1f,
            IntervalCreationLevelKey = 20f,

            FallSpeedBonus = 3,
            FallSpeedLife = 3,
            FallSpeedShield = 3,
            FallSpeedEnemy = 3,
            FallSpeedLevelKey = 3
        };

        var level2 = new LevelData
        {

        };

        var level3 = new LevelData
        {

        };

        Levels.Add(level1);
        Levels.Add(level2);
        Levels.Add(level3);
    }
}
