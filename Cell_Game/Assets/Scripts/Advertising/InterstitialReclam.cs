using UnityEngine;
using GoogleMobileAds.Api;

public class InterstitialReclam : MonoBehaviour
{
    private InterstitialAd _interstitial;
    private const string _adUnitId = "ca-app-pub-3940256099942544/1033173712";

    private void OnEnable() 
    {
        _interstitial = new InterstitialAd(_adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        _interstitial.LoadAd(request);
    }

    public void ShowASD() 
    {
        if(_interstitial.IsLoaded())
        {
            _interstitial.Show();
        }
    }
}
