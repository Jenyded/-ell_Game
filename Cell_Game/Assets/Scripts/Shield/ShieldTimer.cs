using UnityEngine;
using UnityEngine.UI;

public class ShieldTimer : MonoBehaviour
{
    public float coolDown;
    [HideInInspector] public bool isCoolDown;   

    private Image _shieldImage;
    private Shield _playerShield;
    
    private void Start()
    {
        _shieldImage = GetComponent<Image>();
        _playerShield = GameObject.FindGameObjectWithTag("Player").GetComponent<Shield>();
        isCoolDown = true;
    }

    private void Update()
    {
        if (isCoolDown)
        {
            _shieldImage.fillAmount -= 1 / coolDown * Time.deltaTime;
            
            if(_shieldImage.fillAmount <= 0)
            {
                _shieldImage.fillAmount = 1;
                isCoolDown = false;
                _playerShield.shield.SetActive(false);
                gameObject.SetActive(false);                 
            }
        } 
    }

    public void ResetTimer()
    {
        _shieldImage.fillAmount = 1;
    }
}
