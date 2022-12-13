using UnityEngine;

public class ClashWall : Clash
{
    public override void ClashCollisionWithObject(string tag)
    {
        if (tag.Equals("Player"))
        {
            EnableEffect();
        }
    }

    public override void EnableEffect()
    {
        Effect.SetActive(true);
        Instantiate(Effect, transform.position, Quaternion.identity);
    }
}
