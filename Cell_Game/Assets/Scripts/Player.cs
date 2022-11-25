using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField]
    protected int life = 5;
    [SerializeField] TMP_Text lifeText;

    private Material materialBlink;
    private Material materialDefault;
    private SpriteRenderer spriteRend;

    public GameObject shield;
    public ShieldTimer shieldTimer;
    private bool _shild = false;


    private void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();

        materialBlink = Resources.Load("PlayerBlink", typeof(Material)) as Material;
        materialDefault = spriteRend.material;
    }

    private void Update()
    {
        lifeText.text = life.ToString();

        if (shieldTimer.isCoolDown == false)
        {
            _shild = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        return;
        if (collision.CompareTag("EnemyTag"))
        {
            if (_shild == false)
            {
                life--;
                spriteRend.material = materialBlink;
            }

            if (life <= -1)
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

        if (collision.CompareTag("ShieldTag"))
        {
            _shild = true;
            shield.SetActive(true);
            shieldTimer.gameObject.SetActive(true);
            shieldTimer.isCoolDown = true;
            Destroy(collision.gameObject);
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

