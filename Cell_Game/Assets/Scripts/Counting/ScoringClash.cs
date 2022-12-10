using UnityEngine;
using TMPro;

public abstract class ScoringClash : EffectCollision
{
    protected int score;
    [SerializeField] TMP_Text scoreText;

    protected int life = 5;
    [SerializeField] TMP_Text lifeText;

    public abstract void PointsManager(string tag);
    public abstract void KillPlayer();


    private void Start()
    {
        collision += ClashCollision;
    }

    public void ClashCollision(string tag)
    {
        PointsManager(tag);        
    }

    private void OnDestroy()
    {
        collision -= ClashCollision;
    }

    private void Update()
    {
        scoreText.text = score.ToString();
        lifeText.text = life.ToString();
    }
}
