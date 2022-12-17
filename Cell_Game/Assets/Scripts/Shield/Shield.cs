using UnityEngine;

public class Shield : EffectCollision
{
    private Material _materialBlink;
    private Material _materialDefault;
    private SpriteRenderer _spriteRend;

    public GameObject shieldObj;
    public ShieldTimer shieldTimer;
    public static bool shieldActivity = false;

    private int _life;
    private PlayerLife playerLife;

    private void Start()
    {
        _spriteRend = GetComponent<SpriteRenderer>();
        _materialBlink = Resources.Load("PlayerBlink", typeof(Material)) as Material;
        _materialDefault = _spriteRend.material;        
    }

    private void Update()
    {
        _life = playerLife.GetLife();
        if (shieldTimer.isCoolDown == false)
        {
            shieldActivity = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyTag"))
        {
            if (shieldActivity == false)
            {
                _spriteRend.material = _materialBlink;
            }

            if (_life >= 0)
            {
                Invoke("ResetMaterial", 0.2f);
            }            
        }

        if (collision.CompareTag("ShieldTag"))
        {
            shieldActivity = true;
            shieldObj.SetActive(true);
            shieldTimer.gameObject.SetActive(true);
            shieldTimer.isCoolDown = true;
            Destroy(collision.gameObject);
        }
    }

    void ResetMaterial()
    {
        _spriteRend.material = _materialDefault;
    }
}
