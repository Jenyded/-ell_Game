using TMPro;
using UnityEngine;

public class UILife : MonoBehaviour
{
    [SerializeField] TMP_Text _life;
    [SerializeField] PlayerLife _playerLife;

    private void Update()
    {
        _life.text = _playerLife.GetLife().ToString();
    }
}
