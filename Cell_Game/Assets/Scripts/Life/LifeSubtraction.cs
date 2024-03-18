using Unity.Properties;
using UnityEngine;

public class LifeSubtraction : LifeClash
{
    public override void LifeManager(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            if (Shield.IsShieldActivity != true)
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