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
            IntReclama.ShowADS();
            _countAttempts = 0;
        }
        else
        {
            IntReclama.InterstitialLoad();            
        }
    }

    private void Awake()
    {
        Instance = this;
    }   
}
