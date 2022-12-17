using TMPro;
using UnityEngine;


public class UIScore : MonoBehaviour
{
    [SerializeField] TMP_Text _score;
    [SerializeField] PlayerScore _playerScore;

    private void Update()
    {
        _score.text = _playerScore.GetScore().ToString();
    }
}
