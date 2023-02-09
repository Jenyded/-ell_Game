using UnityEngine;
using UnityEngine.UI;

public class ShieldTimer : MonoBehaviour
{
    public float CoolDown;
    [HideInInspector] public bool isCoolDown;
    private float TimerUnit = 1f;

    private Image _shieldImage;
    private Shield _playerShield;

    private void Start()
    {
        _shieldImage = GetComponent<Image>();
        _playerShield = GameObject.FindGameObjectWithTag("PlayerTag").GetComponent<Shield>();
        isCoolDown = true;
    }

    private void Update()
    {
        if (isCoolDown)
        {
            _shieldImage.fillAmount -= TimerUnit / CoolDown * Time.deltaTime;

            if (_shieldImage.fillAmount <= 0)
            {
                _shieldImage.fillAmount = TimerUnit;
                isCoolDown = false;
                Player.Instance.SetViewShield(false);
                gameObject.SetActive(false);
            }
        }
    }

    public void ResetTimer()
    {
        _shieldImage.fillAmount = TimerUnit;
    }
}
