using UnityEngine;

public class ClashEnemy : Clash
{
    public override void ClashCollisionWithObject(string tag)
    {
        if (tag.Equals("Player"))
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
        _effect.SetActive(true);
        Instantiate(_effect, transform.position, Quaternion.identity);
    }
}
