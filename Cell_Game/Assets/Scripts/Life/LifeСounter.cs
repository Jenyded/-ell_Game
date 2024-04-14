using UnityEngine;

public class LifeСounter : LifeClash
{    
    public override void LifeManager(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            if(Player.Life >= 0)
            {
              Player.Life++;
            }            
        } 
        if (tag.Equals("Destroy_panel"))
        {
            base.BaseDestroy();
        }
    }    
}
