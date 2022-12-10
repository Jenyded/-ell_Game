using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : ScoringClash
{
    public override void PointsManager(string tag)
    {
        if (tag.Equals("BonusTag"))
        {
            score++;                       
        }

        if (tag.Equals("LifeTag"))
        {
            life++;
        }

        if (tag.Equals("EnemyTag"))
        {
            if (Shield._shild != true)
            {
                life--;
                score -= 5;

                if (score <= 0)
                {
                    score = 0;
                }

                if (life <= -1)
                {
                    KillPlayer();
                }
            }
        }
    }
    public override void KillPlayer()
    {
        Destroy(gameObject);
    }
}
