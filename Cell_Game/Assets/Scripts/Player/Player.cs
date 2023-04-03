using UnityEngine;

public class Player : MonoBehaviour
{
    public static int Life = 5;
    public static int Score;
    public static int HighScoreCounter;
    public static int Bonus;
    public static bool IsShield;    
    public static Player Instance;
    [SerializeField] ShieldTimer shildTimer;
    [SerializeField] GameObject shielSpheredObj;       

    private void Awake()
    {
        Instance = this;
    }

    public ShieldTimer GetShieldTimer()
    {
        return shildTimer;
    }

    public void SetViewShield(bool state)
    {
        shielSpheredObj.SetActive(state);
    }    
}