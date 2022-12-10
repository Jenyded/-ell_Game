using System;
using UnityEngine;

public class EffectCollision : MonoBehaviour
{
    protected Action<string> collision;
   
    private void OnTriggerEnter2D(Collider2D collider)
    {
        var tag = collider.tag;
        collision?.Invoke(tag);        
    }

    protected void BaseDestroy()
    {
        Destroy(gameObject);
    }
}
