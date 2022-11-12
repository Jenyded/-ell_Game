using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShield : MonoBehaviour
{
    public GameObject shield;

    void Start()
    {
        StartCoroutine(Spawn_Shield());
    }

    IEnumerator Spawn_Shield()
    {
        while (true)
        {
            Instantiate(shield, new Vector2(Random.Range(-1.96f, 1.49f), 7.5f), Quaternion.identity);
            yield return new WaitForSeconds(6.1f);
        }
    }
}
