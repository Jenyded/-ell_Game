using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLife : MonoBehaviour
{
    public GameObject life;

    void Start()
    {
        StartCoroutine(Spawn_Life());
    }

    IEnumerator Spawn_Life()
    {
        while (true)
        {
            Instantiate(life, new Vector2(Random.Range(-1.96f, 1.49f), 7.5f), Quaternion.identity);
            yield return new WaitForSeconds(4.2f);
        }
    }
}
