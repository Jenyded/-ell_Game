using UnityEngine;

public class ADSRunning : MonoBehaviour
{
    public static ADSRunning Instance;
    public InterstitialReclam IntReclama;
    private int _countAttempts;
    private readonly int _numberOfAttempts = 3;

    public void ASD()
    {
        _countAttempts++;
        Debug.Log("Колличество попыток " + _countAttempts);
        if (_countAttempts == _numberOfAttempts)
        {
            Debug.Log("Реклама включена!");
            IntReclama.ShowASD();
            _countAttempts = 0;
        }
    }

    private void Awake()
    {
        Instance = this;
    }

    //реклама с записью в реестр:
    //public void ASDsh()
    //{
    //    _countAttempts += 1;
    //    PlayerPrefs.SetInt("Count_Losses", _countAttempts);
    //    if (PlayerPrefs.GetInt("Count_Losses") == 3)
    //    {
    //        IntReclama.ShowASD();
    //        PlayerPrefs.SetInt("Count_Losses", 0);
    //    }
    //}
    //private void Start()
    //{
    //    _countAttempts = PlayerPrefs.GetInt("Count_Losses");
    //}
}
