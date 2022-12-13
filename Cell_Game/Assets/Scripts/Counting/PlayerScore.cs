using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : ScoringClash
{
    public override void PointsManager(string tag)
    {
        if (tag.Equals("BonusTag"))
        {
            Score++;                       
        }

        if (tag.Equals("LifeTag"))
        {
            Life++;
        }

        if (tag.Equals("EnemyTag"))
        {
            if (Shield.shieldActivity != true)
            {
                Life--;
                Score -= 2;

                if (Score <= 0)
                {
                    Score = 0;
                }

                if (Life <= -1)
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
