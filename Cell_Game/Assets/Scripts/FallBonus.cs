using UnityEngine;

public class FallBonus : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 3f;
    public GameObject bonusEffect;

    void Update()
    {
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            Instantiate(bonusEffect, transform.position, Quaternion.identity);               
    }
}
