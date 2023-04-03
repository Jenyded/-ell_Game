using UnityEngine;

public class PointsSubtraction : ScoringClash
{
    public override void PointsManager(string tag)
    {        
        if (tag.Equals("PlayerTag"))
        {
            if (Shield.IsShieldActivity != true)
            {
                Player.Score -= 2;

                if (Player.Score <= 0)
                {
                    Player.Score = 0;
                }
            }
        }
    }
}
