using UnityEngine;

public class ClashLife : Clash
{
    public override void ClashCollisionWithObject(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            EnableEffect();
            base.BaseDestroy();
        }
    }

    public override void EnableEffect()
    {
        Effect.SetActive(true);
        Instantiate(Effect, transform.position, Quaternion.identity);
    }
}
