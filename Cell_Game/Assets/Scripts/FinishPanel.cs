using UnityEngine;

public class FinishPanel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyTag")
            Destroy(other.gameObject);       
    }
}
