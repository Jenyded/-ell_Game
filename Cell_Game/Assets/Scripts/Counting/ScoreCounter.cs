using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : ScoringClash
{
    public override void PointsManager(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            Player.Score++;
        }        
    }
}
