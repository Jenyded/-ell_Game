using UnityEngine;

public class ClashEnemy : Clash
{
    public override void ClashCollisionWithObject(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            EnableEffect();
            base.BaseDestroy();
        }

        if (tag.Equals("Finish_panelTag"))
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
