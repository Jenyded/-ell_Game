using UnityEngine;

public class CreatingObject : MonoBehaviour
{
    [SerializeField] private GameObject _bonus;
    [SerializeField] private GameObject _life;
    [SerializeField] private GameObject _shield;
    [SerializeField] private GameObject _enemy;

    private float _countingTimeBonus;
    private float _countingTimeLife;
    private float _countingTimeShield;
    private float _countingTimeEnemy;

    [SerializeField] private float _intervalCreationBonus;
    [SerializeField] private float _intervalCreationLife;
    [SerializeField] private float _intervalCreationShield;
    [SerializeField] private float _intervalCreationEnemy;

    private readonly float _creationPosXLeft = -1.96f;
    private readonly float _creationPosXright = 1.49f;
    private readonly float _creationPosY = 7.5f;
    private readonly float _timeDestroy = 5f;

    private void Update()
    {
        _countingTimeBonus += Time.deltaTime;
        if (_countingTimeBonus >= _intervalCreationBonus)
        {
            TimeCreation(_bonus, 3);
            _countingTimeBonus = 0;
        }

        _countingTimeLife += Time.deltaTime;
        if (_countingTimeLife >= _intervalCreationLife)
        {
            TimeCreation(_life, 3);
            _countingTimeLife = 0;
        }

        _countingTimeShield += Time.deltaTime;
        if (_countingTimeShield >= _intervalCreationShield)
        {
            TimeCreation(_shield, 3);
            _countingTimeShield = 0;
        }

        _countingTimeEnemy += Time.deltaTime;
        if (_countingTimeEnemy >= _intervalCreationEnemy)
        {
            TimeCreation(_enemy, 3);
            _countingTimeEnemy = 0;
        }

    }

    private void TimeCreation(GameObject obg, float speed)
    {
        GameObject copy = Instantiate(obg, new Vector2(Random.Range(_creationPosXLeft, _creationPosXright), _creationPosY), Quaternion.identity);
        var falingObg = copy.GetComponent<FallingObjects>();
        if (falingObg != null)
        {
            falingObg.Init(speed);
        }
        Destroy(copy, _timeDestroy);
    }
}
