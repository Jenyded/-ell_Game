using System;
using UnityEngine;

public class EffectCollision : MonoBehaviour
{
    protected Action<string> Collision;
   
    private void OnTriggerEnter2D(Collider2D collider)
    {
        var tag = collider.tag;
        Collision?.Invoke(tag);        
    }

    protected void BaseDestroy()
    {
        Destroy(gameObject);
    }
}
