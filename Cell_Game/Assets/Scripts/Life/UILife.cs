using TMPro;
using UnityEngine;

public class UILife : MonoBehaviour
{
    [SerializeField] TMP_Text _lifeText;    

    private void Update()
    {
        if(Player.Life >= 0)
        {
            _lifeText.text = Player.Life.ToString();
        }            
    }
}
