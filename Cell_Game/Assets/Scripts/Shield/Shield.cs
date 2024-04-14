using UnityEngine;

public class Shield : ShieldClash 
{
    public static bool IsShieldActivity = false;

    private void Update()
    {
        if (Player.Instance.GetShieldTimer().isCoolDown == false)
        {
            IsShieldActivity = false;
        }
    }
    
    public override void ShieldCollisionWithObjects(string tag)
    { 
        if (tag.Equals("PlayerTag"))        
        {
            IsShieldActivity = true;
            Player.Instance.SetViewShield(true);
            Player.Instance.GetShieldTimer().gameObject.SetActive(true);
            Player.Instance.GetShieldTimer().isCoolDown = true;
            if (!AudioListener.pause)
            {
                AudioManager.instance.Play("Sound_Shild");
            }
            Destroy(gameObject);
        }
        if (tag.Equals("Destroy_panel"))
        {
            base.BaseDestroy();
        }
    }   
}
