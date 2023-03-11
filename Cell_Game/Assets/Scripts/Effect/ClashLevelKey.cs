using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClashLevelKey : Clash
{
    public override void ClashCollisionWithObject(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            EnableEffect();
            if (!AudioListener.pause)
            {
                AudioManager.instance.Play("Sound_Level");
            }
            base.BaseDestroy();
            //LevelsData.SwitchLevel();
            FunctionsButton.Instance.SetActiveButtonSwitchLevel();
        }
    }

    public override void EnableEffect()
    {
        Effect.SetActive(true);
        Instantiate(Effect, transform.position, Quaternion.identity);
    }
}
