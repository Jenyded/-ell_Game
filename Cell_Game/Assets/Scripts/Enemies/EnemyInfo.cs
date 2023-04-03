using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyInfo", menuName = "Gameplay/New EnemyInfo")]

public class EnemyInfo : ScriptableObject
{
    [SerializeField] private List<DataEnemy> _enemes;     

    public GameObject GetGameObj(string id)
    {
        foreach (var item in _enemes)
        {
            if (item.Id == id)
                return item.Enemy;
        }

        return null;
    }

    [System.Serializable]
    class DataEnemy
    {
        public string Id;
        public GameObject Enemy;
    }
}
