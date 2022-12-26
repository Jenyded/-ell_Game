using UnityEngine;

public class Shield : ShieldClash  //PlayerLife 
{
    private Material _materialBlink;
    private Material _materialDefault;
    private SpriteRenderer _spriteRend;

    
    //public ShieldTimer shieldTimer;
    public static bool shieldActivity = false;
        

    private void Start()
    {
        _spriteRend = GetComponent<SpriteRenderer>();
        _materialBlink = Resources.Load("PlayerBlink", typeof(Material)) as Material;
        _materialDefault = _spriteRend.material;        
    }

    private void Update()
    {       
        if (Player.Instance.GetShieldTimer().isCoolDown == false)
        {
            shieldActivity = false;
        }
    }

   public override void ShieldCollisionWithObjects(string tag)
    //private void OnTriggerEnter2D(Collider2D collision)
    {
        if (tag.Equals("PlayerTag"))
        // if (collision.CompareTag("EnemyTag"))
        {
            if (shieldActivity == false)
            {
                _spriteRend.material = _materialBlink;
            }

            if (Player.Life >= 0)
            {
                Invoke("ResetMaterial", 0.2f);
            }            
        }
        if (tag.Equals("ShieldTag"))
        //if (collision.CompareTag("ShieldTag"))
        {
            shieldActivity = true;
            Player.Instance.SetViewShield(true);
            Player.Instance.GetShieldTimer().gameObject.SetActive(true);
            Player.Instance.GetShieldTimer().isCoolDown = true;
            Destroy(gameObject);
        }
    }

    void ResetMaterial()
    {
        _spriteRend.material = _materialDefault;
    }
}
