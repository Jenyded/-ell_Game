using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    [SerializeField] TMP_Text _scoreText;
    [SerializeField] TMP_Text _highScoreText;

    private void Update()
    {
        _scoreText.text = Player.Score.ToString();
        _highScoreText.text = Player.HighScoreCounter.ToString();
    }
}
