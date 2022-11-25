using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClashEnemy : Clash
{
    public override void ClashCollisionWithObject(string tag)
    {
        

        if (tag.Equals("Player"))
        {
            Enable≈ffect();
        }
    }

    public override void Enable≈ffect()
    {
        _effect.SetActive(true);
        Instantiate(_effect, transform.position, Quaternion.identity);
    }
}
