using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeСounter : LifeClash
{
    //public int GetLife()
    //{
    //    return Life;
    //}

    public override void LifeManager(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            if(Player.Life >= 0)
            {
              Player.Life++;
            }            
        } 
    }    
}
