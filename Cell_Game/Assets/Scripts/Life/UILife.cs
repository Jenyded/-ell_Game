using TMPro;
using UnityEngine;

public class UILife : MonoBehaviour
{
    [SerializeField] TMP_Text _life;    

    private void Update()
    {
        if(Player.Life >= 0)
        {
            _life.text = Player.Life.ToString();
        }            
    }
}
