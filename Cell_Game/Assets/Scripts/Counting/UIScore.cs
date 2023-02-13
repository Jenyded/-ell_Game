using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    [SerializeField] TMP_Text _score;
    [SerializeField] TMP_Text _highScore;

    private void Update()
    {
        _score.text = Player.Score.ToString();
        _highScore.text = Player.HighScoreCounter.ToString();
    }
}
