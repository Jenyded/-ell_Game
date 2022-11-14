using UnityEngine;

public class FallShield : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 3f;
    public GameObject shieldEffect;

    void Update()
    {
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            Instantiate(shieldEffect, transform.position, Quaternion.identity);
    }
}
