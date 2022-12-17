using UnityEngine;

public class PlayerLife : LifeClash
{
    [SerializeField] private GameObject _buttonRestart;

    public int GetLife()
    {
        return Life;
    }

    public override void LifeManager(string tag)
    {
        if (tag.Equals("LifeTag"))
        {
            Life++;
        }

        if (tag.Equals("EnemyTag"))
        {
            if (Shield.shieldActivity != true)
            {
                Life--;        
                
                if (Life <= -1)
                {
                    KillPlayer();
                    _buttonRestart.SetActive(true);
                   
                    if (Life <= 0)
                    {
                        Life = 0;
                    }
                }
            }
        }
    }
    public override void KillPlayer()
    {
        Destroy(gameObject);
    }
}
