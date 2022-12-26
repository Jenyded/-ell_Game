using TMPro;
using UnityEngine;


public class UIScore : MonoBehaviour
{
    [SerializeField] TMP_Text _score;
   // [SerializeField] PlayerScore _playerScore;

    private void Update()
    {
        _score.text = Player.Score.ToString(); 
            
            //_playerScore.GetScore().ToString();
    }
}
