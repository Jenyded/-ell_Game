using UnityEngine;
using TMPro;

public class UIButton : MonoBehaviour
{
    [SerializeField] TMP_Text _textLevelButton;
    public static UIButton Instance;
    private int _meaning;

    private void Awake()
    {
        Instance = this;
    }
    
    public void ReflectLevel()
    {
        _meaning = LevelsData.GetCurentLevel() + 1;
        _textLevelButton.text = "Go to level " + (_meaning + 1).ToString();
    }
}
