using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    public static int Life = 5;
    public static int Score;
    public static int HighScoreCounter;
    public static int Bonus;
    public static bool IsShield;    
    public static Player Instance;
    [SerializeField] ShieldTimer shildTimer;
    [SerializeField] GameObject shieldSpheredObj;       

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Instance.GetShieldTimer().isCoolDown == false)
        {
            Shield.IsShieldActivity = false;
        }
    }
    
    public ShieldTimer GetShieldTimer()
    {
        return shildTimer;
    }

    public void SetViewShield(bool state)
    {
        shieldSpheredObj.SetActive(state);
    }    
}