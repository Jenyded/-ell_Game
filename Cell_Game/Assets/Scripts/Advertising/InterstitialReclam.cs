using UnityEngine;
using GoogleMobileAds.Api;

public class InterstitialReclam : MonoBehaviour
{
    private InterstitialAd _interstitial;
    private const string _adUnitId = "ca-app-pub-3940256099942544/1033173712";

    private void Start()
    {
        _interstitial = new InterstitialAd(_adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        _interstitial.LoadAd(request);
    }
    
    public void InterstitialLoad()
    {
        if (_interstitial != null)
        {
            if (!_interstitial.IsLoaded())
            {
                _interstitial.Destroy();
                _interstitial = new InterstitialAd(_adUnitId);
                AdRequest request = new AdRequest.Builder().Build();
                _interstitial.LoadAd(request);
                Debug.Log("�������� ������� !!!");
            }
        }
    }

    public void ShowADS()
    {
        if (_interstitial.IsLoaded())
        {
            _interstitial.Show();
        }
    }
}
