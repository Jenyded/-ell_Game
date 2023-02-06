using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    [SerializeField] TMP_Text _score;
   
    private void Update()
    {
        _score.text = Player.Score.ToString();           
    }
}
