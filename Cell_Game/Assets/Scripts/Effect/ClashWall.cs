using UnityEngine;

public class ClashWall : Clash
{
    public override void ClashCollisionWithObject(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            AudioManager.instance.Play("Sound_HitWall");
            EnableEffect();
        }
    }

    public override void EnableEffect()
    {
        Effect.SetActive(true);
        Instantiate(Effect, transform.position, Quaternion.identity);
    }
}
