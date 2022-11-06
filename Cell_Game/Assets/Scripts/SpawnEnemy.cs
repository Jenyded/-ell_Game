using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    
    void Start()
    {
        StartCoroutine(Spawn_Enemy());       
    }

    IEnumerator Spawn_Enemy()
    {
        while (true)
        {
            Instantiate(enemy, new Vector2(Random.Range(-1.96f, 1.49f), 7.5f), Quaternion.identity);
            yield return new WaitForSeconds(1.1f);    
        }
    }    
}
