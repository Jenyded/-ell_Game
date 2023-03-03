using UnityEngine;

public class CreatingObject : MonoBehaviour
{
    [SerializeField] private GameObject _bonus;
    [SerializeField] private GameObject _life;
    [SerializeField] private GameObject _shield;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _levelKey;

    private float _countingTimeBonus;
    private float _countingTimeLife;
    private float _countingTimeShield;
    private float _countingTimeEnemy;
    private float _countingLevelKey;   

    private readonly float _creationPosXLeft = -1.96f;
    private readonly float _creationPosXright = 1.49f;
    private readonly float _creationPosY = 7.5f;
    private readonly float _timeDestroy = 5f;

    private LevelData _levelData;

    private bool _isNeedUpdate = false;

    private void Update()
    {
        if (_isNeedUpdate == false)
        {
            return;
        }

        _countingTimeBonus += Time.deltaTime;
        if (_countingTimeBonus >= _levelData.IntervalCreationBonus)
        {
            TimeCreation(_bonus, LevelsData.Levels[0].FallSpeedBonus);
            _countingTimeBonus = 0;
        }

        _countingTimeLife += Time.deltaTime;
        if (_countingTimeLife >= _levelData.IntervalCreationLife)
        {
            TimeCreation(_life, LevelsData.Levels[0].FallSpeedLife);
            _countingTimeLife = 0;
        }

        _countingTimeShield += Time.deltaTime;
        if (_countingTimeShield >= _levelData.IntervalCreationShield)
        {
            TimeCreation(_shield, LevelsData.Levels[0].FallSpeedShield);
            _countingTimeShield = 0;
        }

        _countingTimeEnemy += Time.deltaTime;
        if (_countingTimeEnemy >= _levelData.IntervalCreationEnemy)
        {
            TimeCreation(_enemy, LevelsData.Levels[0].FallSpeedEnemy);
            _countingTimeEnemy = 0;
        }

        _countingLevelKey += Time.deltaTime;
        if (_countingLevelKey >= _levelData.IntervalCreationLevelKey)
        {
            TimeCreation(_levelKey, LevelsData.Levels[0].FallSpeedLevelKey);
            _countingLevelKey = 0;
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

    public void Init(LevelData levelData)
    {
        _levelData = levelData;
        _isNeedUpdate = true;
    }
}
