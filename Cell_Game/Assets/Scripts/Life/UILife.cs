using TMPro;
using UnityEngine;

public class UILife : MonoBehaviour
{
    [SerializeField] TMP_Text _life;
    //[SerializeField] PlayerLife _playerLife;

    private void Update()
    {
        if(Player.Life >= 0)
        {
            _life.text = Player.Life.ToString();
        }        
            
            //_playerLife.GetLife().ToString();
    }
}
