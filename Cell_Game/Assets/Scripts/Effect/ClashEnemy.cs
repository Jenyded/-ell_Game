using UnityEngine;

public class ClashEnemy : Clash
{
    public override void ClashCollisionWithObject(string tag)
    {
        if (tag.Equals("Player"))
        {
            EnableEffect();
        }

        if (tag.Equals("Finish_panelTag"))
        {
            EnableEffect();
        }
    }

    public override void EnableEffect()
    {
        _effect.SetActive(true);
        Instantiate(_effect, transform.position, Quaternion.identity);
    }
}
