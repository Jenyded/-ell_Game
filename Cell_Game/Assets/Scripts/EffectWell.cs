using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectWell : MonoBehaviour
{
    public GameObject wellEffect;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            Instantiate(wellEffect, transform.position, Quaternion.identity);
        Debug.Log("Контакт");
    }
}
