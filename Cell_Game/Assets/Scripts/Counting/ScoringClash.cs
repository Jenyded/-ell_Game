using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ScoringClash : EffectCollision
{      
    public abstract void PointsManager(string tag);   

    private void Start()
    {
        Collision += ClashCollision;
    }

    public void ClashCollision(string tag)
    {
        PointsManager(tag);        
    }

    private void OnDestroy()
    {
        Collision -= ClashCollision;
    }   
}
