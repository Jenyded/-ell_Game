using UnityEngine;

public class Shield : ShieldClash 
{
    public static bool ShieldActivity = false;

    private void Update()
    {
        if (Player.Instance.GetShieldTimer().isCoolDown == false)
        {
            ShieldActivity = false;
        }
    }
    
    public override void ShieldCollisionWithObjects(string tag)
    { 
        if (tag.Equals("PlayerTag"))        
        {
            ShieldActivity = true;
            Player.Instance.SetViewShield(true);
            Player.Instance.GetShieldTimer().gameObject.SetActive(true);
            Player.Instance.GetShieldTimer().isCoolDown = true;
            Destroy(gameObject);
        }
    }   
}
