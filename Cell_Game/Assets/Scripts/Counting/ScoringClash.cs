using UnityEngine;
using TMPro;

public abstract class ScoringClash : EffectCollision
{
    protected int Score;
    [SerializeField] TMP_Text _scoreText;

    protected int Life = 5;
    [SerializeField] TMP_Text _lifeText;

    public abstract void PointsManager(string tag);
    public abstract void KillPlayer();


    private void Start()
    {
        Collision += ClashCollision;
    }

    public void ClashCollision(string tag)
    {
        PointsManager(tag);        
    }

    private void OnDestroy()
    {
        Collision -= ClashCollision;
    }

    private void Update()
    {
        _scoreText.text = Score.ToString();
        _lifeText.text = Life.ToString();
    }      
}
