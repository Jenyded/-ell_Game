using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClashLevelKey : Clash


{
    public override void ClashCollisionWithObject(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            //EnableEffect();
            //if (!AudioListener.pause)
            //{
            //    AudioManager.instance.Play("Sound_Life");
            //}
            //LevelsData.Levels[0];
            base.BaseDestroy();
        }
    }

    public override void EnableEffect()
    {
        Effect.SetActive(true);
        Instantiate(Effect, transform.position, Quaternion.identity);
    }
}
