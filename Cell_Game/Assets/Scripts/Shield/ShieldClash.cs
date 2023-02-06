using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShieldClash : EffectCollision
{
    public abstract void ShieldCollisionWithObjects(string tag);

    private void Start()
    {
        Collision += ClashCollision;
    }

    public void ClashCollision(string tag)
    {
        ShieldCollisionWithObjects(tag);
    }

    private void OnDestroy()
    {
        Collision -= ClashCollision;
    }
}
