using UnityEngine;

public class Shield : MonoBehaviour //ShieldClash
{
    private Material _materialBlink;
    private Material _materialDefault;
    private SpriteRenderer _spriteRend;
    private float _materialOnTime = 0.2f;
    public static bool ShieldActivity = false;

    private void Update()
    {
        if (Player.Instance.GetShieldTimer().isCoolDown == false)
        {
            ShieldActivity = false;
        }
    }

    private void Start()
    {
        _spriteRend = GetComponent<SpriteRenderer>();
        _materialBlink = Resources.Load("PlayerBlink", typeof(Material)) as Material;
        _materialDefault = _spriteRend.material;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    // public override void ShieldCollisionWithObjects(string tag)
    {
        if (collision.CompareTag("PlayerTag"))
        // if (tag.Equals("PlayerTag"))        
        {
            if (ShieldActivity == false)
            {
                _spriteRend.material = _materialBlink;
            }

            if (Player.Life >= 0)
            {
                Invoke("ResetMaterial", _materialOnTime);
            }
        }

        if (collision.CompareTag("PlayerTag"))
        //if (tag.Equals("ShieldTag"))        
        {
            ShieldActivity = true;
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
