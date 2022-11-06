using UnityEngine;

public class FallEnimy : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 3f;
    public GameObject enemyEffect;

    void Update()
    {
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Finish_panelTag")
            Instantiate(enemyEffect, transform.position, Quaternion.identity);        
    }
}
