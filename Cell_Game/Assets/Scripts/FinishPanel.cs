using UnityEngine;

public class FinishPanel : MonoBehaviour
{
    // public GameObject enemyEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyTag")
            Destroy(other.gameObject);
       // Instantiate(enemyEffect, transform.position, Quaternion.identity);
    }
}
