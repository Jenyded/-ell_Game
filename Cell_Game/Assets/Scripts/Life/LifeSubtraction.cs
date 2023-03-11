using UnityEngine;

public class LifeSubtraction : LifeClash
{
    public override void LifeManager(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            if (Shield.ShieldActivity != true)
            {
                Player.Life--;

                if (Player.Life <= -1)
                {
                    Player.Instance.gameObject.SetActive(false);
                    FunctionsButton.Instance.SetActiveButtonRestart();                    
                }
            }
        }
    }    
}
