using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishDestroyObject : EffectCollision
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyTag")
            
            Destroy(other.gameObject);

        if (other.gameObject.tag == "BonusTag")
            Destroy(other.gameObject);

        if (other.gameObject.tag == "LifeTag")
            Destroy(other.gameObject);

        if (other.gameObject.tag == "ShieldTag")
            Destroy(other.gameObject);
    }
}
