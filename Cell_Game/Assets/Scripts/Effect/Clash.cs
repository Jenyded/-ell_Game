using UnityEngine;

public abstract class Clash : EffectCollision
{
    [SerializeField] protected GameObject _effect;
   
    public abstract void ClashCollisionWithObject(string tag);
    
    public abstract void EnableEffect();


    private void Start()
    {
        collision += ClashCollision;
    }
    
    public void ClashCollision(string tag)
    {
        ClashCollisionWithObject(tag);
    }

    private void OnDestroy()
    {
        collision -= ClashCollision;
    }
}
