using UnityEngine;

public class ClashLevelKey : Clash
{
    public override void ClashCollisionWithObject(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            ClashEnemy.Instance.ExplosionEnemy();
            EnableEffect();            
            if (!AudioListener.pause)
            {
                AudioManager.instance.Play("Sound_Level");
            }
            base.BaseDestroy();
            FunctionsButton.Instance.Invoke("SetActiveButtonSwitchLevel", 1f);
        }
        if (tag.Equals("Destroy_panel"))
        {
            base.BaseDestroy();
        }
    }

    public override void EnableEffect()
    {
        Effect.SetActive(true);
        Instantiate(Effect, transform.position, Quaternion.identity);
    }
}
