using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGame : MonoBehaviour
{
    [SerializeField] private SpriteRenderer SpriteRendBackground;
    private LevelData _levelData;

    public void Init(LevelData levelData)
    {
        _levelData = levelData;
       SpriteRendBackground.sprite = _levelData.LevelBackgroundGame;
    }
}
