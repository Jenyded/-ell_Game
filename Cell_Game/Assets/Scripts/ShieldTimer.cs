using UnityEngine;
using UnityEngine.UI;

public class ShieldTimer : MonoBehaviour
{
    public float coolDown;
    [HideInInspector] public bool isCoolDown;   

    private Image _shieldImage;
    private Player _player;
    
    private void Start()
    {
        _shieldImage = GetComponent<Image>();
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
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
                _player.shield.SetActive(false);
                gameObject.SetActive(false);                 
            }
        } 
    }

    public void ResetTimer()
    {
        _shieldImage.fillAmount = 1;
    }
}
