using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int life = 5;

    private Material materialBlink;
    private Material materialDefault;
    private SpriteRenderer spriteRend;

    public GameObject shield;

    private void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();

        materialBlink = Resources.Load("PlayerBlink", typeof(Material)) as Material;
        materialDefault = spriteRend.material;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyTag"))
        {
            life--;
            spriteRend.material = materialBlink;


            if (life <= 0)
            {
                KillPlayer(); 
            }
            else
            {
                Invoke("ResetMaterial", 0.2f);
            }
        }

        if (collision.CompareTag("LifeTag"))
        {
            life++;
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("ShieldTag"))
        {
            shield.SetActive(true);
        }
    }

    void ResetMaterial()
    {
        spriteRend.material = materialDefault;
    }

    void KillPlayer()
    {
        Destroy(gameObject);
    }
}
