using System.Collections;
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
            yield return new WaitForSeconds(16.1f);
            Instantiate(shield, new Vector2(Random.Range(-1.96f, 1.49f), 7.5f), Quaternion.identity);
        }
    }
}
