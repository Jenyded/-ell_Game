using UnityEngine;

public abstract class Clash : EffectCollision
{
    [SerializeField] protected GameObject _effect;

    public abstract void ClashCollisionWithObject(string tag);

    public abstract void Enable≈ffect();


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
