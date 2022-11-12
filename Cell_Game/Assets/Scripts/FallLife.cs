using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallLife : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 3f;
    public GameObject lifeEffect;

    void Update()
    {
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            Instantiate(lifeEffect, transform.position, Quaternion.identity);
    }
}
