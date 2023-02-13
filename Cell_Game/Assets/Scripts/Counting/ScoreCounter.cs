using UnityEngine;

public class ScoreCounter : ScoringClash
{
    private void Awake()
    {
        if (PlayerPrefs.HasKey("SaveScore"))
        {
            Player.HighScoreCounter = PlayerPrefs.GetInt("SaveScore");
        }
    }

    public override void PointsManager(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            AddScore();
        }
    }

    public void AddScore()
    {
        Player.Score++;
        HighScore();
    }

    public void HighScore()
    {
        if (Player.Score > Player.HighScoreCounter)
        {
            Player.HighScoreCounter = Player.Score;
            PlayerPrefs.SetInt("SaveScore", Player.HighScoreCounter);
        }
    }

    public static void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("SaveScore");
        Player.HighScoreCounter = 0;
    }
}
