using UnityEngine;
using TMPro;

public class UILevel : MonoBehaviour
{
    [SerializeField] TMP_Text _levelText;   
    
    private void Update()
    {
        _levelText.text = LevelsData.CurentLevel().ToString();
    }
}
