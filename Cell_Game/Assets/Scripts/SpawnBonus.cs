using System.Collections;
using UnityEngine;

public class SpawnBonus : MonoBehaviour
{
    public GameObject bonus;

    void Start()
    {
        StartCoroutine(Spawn_Bonus());
    }

    IEnumerator Spawn_Bonus()
    {
        while (true)
        {
            yield return new WaitForSeconds(3.1f);
            Instantiate(bonus, new Vector2(Random.Range(-1.96f, 1.49f), 7.5f), Quaternion.identity);            
        }
    }
}
