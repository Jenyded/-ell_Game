using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    public int score;
    [SerializeField] TMP_Text scoreText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BonusTag")
        {
            Destroy(other.gameObject);
            score++;
        }

        if (other.gameObject.tag == "EnemyTag")
        {
            Destroy(other.gameObject);
            score -= 5;
        }

        if (score <= 0)
        {
            score = 0;
        }
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }
}