using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSubtraction : LifeClash
{
    public override void LifeManager(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            if (Shield.shieldActivity != true)
            {
                Player.Life--;

                if (Player.Life <= -1)
                {
                    //Player.KillPlayer();

                    FunctionsButton.instance.RestartToButton();

                    //if (Player.Life <= 0)
                    //{
                    //    Player.Life = 0;
                    //}
                }
            }
        }
    }
    //public void KillPlayer()
    //{
    //    Destroy(gameObject);
    //}
}
