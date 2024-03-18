using UnityEngine;
using UnityEngine.UI;

public class ShieldTimer : MonoBehaviour
{
    public GameObject ShTm;
    public float CoolDown;
    [HideInInspector] public bool isCoolDown;
    private float _timerUnit = 1f;

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
            _shieldImage.fillAmount -= _timerUnit / CoolDown * Time.deltaTime;

            if (_shieldImage.fillAmount <= 0)
            {
                _shieldImage.fillAmount = _timerUnit;
                isCoolDown = false;
                Player.Instance.SetViewShield(false);
                gameObject.SetActive(false);
            }
        }
    }

   /* public void ResetTimer() // Для двух щитов
    {
        _shieldImage.fillAmount = _timerUnit;
    }*/
}
