using UnityEngine;
using UnityEngine.UI;

public class ShieldTimer : MonoBehaviour
{
    public float coolDown;
    [HideInInspector] public bool isCoolDown;
   

    private Image shieldImage;
    private Player player;
    
    private void Start()
    {
        shieldImage = GetComponent<Image>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        isCoolDown = true;
    }

    private void Update()
    {
        if (isCoolDown)
        {
            shieldImage.fillAmount -= 1 / coolDown * Time.deltaTime;
            
            if(shieldImage.fillAmount <= 0)
            {
                shieldImage.fillAmount = 1;
                isCoolDown = false;
                player.shield.SetActive(false);
                gameObject.SetActive(false);  
                
            }
        } 
    }

    public void ResetTimer()
    {
        shieldImage.fillAmount = 1;
    }
}
