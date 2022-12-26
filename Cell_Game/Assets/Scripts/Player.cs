using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int Life = 5;
    public static int Score;
    public static int Bonus;
    public static bool Shield;
    [SerializeField] ShieldTimer shildTimer;

    public static Player Instance;
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
    //[SerializeField] private GameObject player;

    //public static void KillPlayer()
    //{
    //    Destroy(gameObject);
    //}
}
