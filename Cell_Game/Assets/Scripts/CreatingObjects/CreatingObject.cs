using UnityEngine;

public class CreatingObject : MonoBehaviour
{
    [SerializeField] private GameObject bonus;
    [SerializeField] private GameObject life;
    [SerializeField] private GameObject shield;
    [SerializeField] private GameObject enemy;

    private float _timeBonus;
    private float _timeLife;
    private float _timeShield;
    private float _timeEnemy;

    [SerializeField] private float interval—reationBonus;
    [SerializeField] private float interval—reationLife;
    [SerializeField] private float interval—reationShield;
    [SerializeField] private float interval—reationEnemy;
    
    private float _leftSide = -1.96f;
    private float _rightSide = 1.49f;
    private float _heightInstance = 7.5f;
    private float _timeDestroy = 5f;

    void Update()
    {
        _timeBonus += Time.deltaTime;
        if (_timeBonus >= interval—reationBonus)
        {
            Time—reation(bonus);
            _timeBonus = 0;
        }

        _timeLife += Time.deltaTime;
        if (_timeLife >= interval—reationLife)
        {
            Time—reation(life);
            _timeLife = 0;
        }

        _timeShield += Time.deltaTime;
        if (_timeShield >= interval—reationShield)
        {
            Time—reation(shield);
            _timeShield = 0;
        }

        _timeEnemy += Time.deltaTime;
        if (_timeEnemy >= interval—reationEnemy)
        {
            Time—reation(enemy);
            _timeEnemy = 0;
        }       
    }   

    private void Time—reation(GameObject obg)
    {
        GameObject copy = Instantiate(obg, new Vector2(Random.Range(_leftSide, _rightSide), _heightInstance), Quaternion.identity);
        Destroy(copy, _timeDestroy);
    }
}
