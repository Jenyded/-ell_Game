using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int Life = 5;
    public static int Score;
    public static int Bonus;
    public static bool Shield;
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
