using UnityEngine;

public abstract class LifeClash : EffectCollision
{
    public abstract void LifeManager(string tag);
   
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
