using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelInfo", menuName = "Gameplay/New LevelInfo")]

public class LevelInfo : ScriptableObject
{    
    [SerializeField] private List<DataLevel> _levels;

    public GameObject GetLevel(string id)
    {
        foreach (var item in _levels)
        {
            if (item.Id == id)
                return item.LevelBackground;
        }
        return null;
    }

    [System.Serializable]
    class DataLevel
    {
        public string Id;
        public GameObject LevelBackground;
    }
}
