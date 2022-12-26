using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeClash : EffectCollision
{
    //protected int Life = 5;

    public abstract void LifeManager(string tag);
    // public abstract void KillPlayer();


    private void Start()
    {
        Collision += ClashCollision;
    }

    public void ClashCollision(string tag)
    {
        LifeManager(tag);
    }

    private void OnDestroy()
    {
        Collision -= ClashCollision;
    }
}
