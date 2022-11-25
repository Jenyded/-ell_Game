using System.Collections;
using UnityEngine;

public class CreatingObjects : MonoBehaviour
{
    [SerializeField] private GameObject _object;
    [SerializeField] private float _periodicCreation;
    private float _leftSide = -1.96f;
    private float _rightSide = 1.49f;
    private float _heightInstance = 7.5f;

    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            yield return new WaitForSeconds(_periodicCreation);
            Instantiate(_object, new Vector2(Random.Range(_leftSide, _rightSide), _heightInstance), Quaternion.identity);
        }
    }
}
