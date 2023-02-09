using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Material _materialBlink;
    private Material _materialDefault;
    private SpriteRenderer _spriteRend;
    private float _materialOnTime = 0.2f;

    private void Start()
    {
        _spriteRend = GetComponent<SpriteRenderer>();
        _materialBlink = Resources.Load("PlayerBlink", typeof(Material)) as Material;
        _materialDefault = _spriteRend.material;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyTag"))
        {
            if (Shield.ShieldActivity == false)
            {
                _spriteRend.material = _materialBlink;
            }
            
            if (Player.Life >= 0)
            {
                Invoke("ResetMaterial", _materialOnTime);
            }
        }
    }

    void ResetMaterial()
    {
        _spriteRend.material = _materialDefault;
    }
}
