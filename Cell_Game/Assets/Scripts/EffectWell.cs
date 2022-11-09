using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class EffectWell : MonoBehaviour
{
    public GameObject wellEffect;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            wellEffect.SetActive(true);
            Instantiate(wellEffect, transform.position, Quaternion.identity);
        }                  
    }
}

