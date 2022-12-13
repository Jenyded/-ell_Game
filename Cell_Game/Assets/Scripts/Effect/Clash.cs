using UnityEngine;

public abstract class Clash : EffectCollision
{
    [SerializeField] protected GameObject Effect;
   
    public abstract void ClashCollisionWithObject(string tag);
    
    public abstract void EnableEffect();


    private void Start()
    {
        Collision += ClashCollision;
    }
    
    public void ClashCollision(string tag)
    {
        ClashCollisionWithObject(tag);
    }

    private void OnDestroy()
    {
        Collision -= ClashCollision;
    }
}
