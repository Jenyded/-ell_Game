using UnityEngine;
using UnityEngine.SceneManagement;

public class FunctionsButton : MonoBehaviour
{
    [SerializeField] private GameObject _buttonRestart;
    [SerializeField] private GameObject _buttonExitToMenu;

    public static FunctionsButton instance;

    private void Awake()
    {
        instance = this;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Scene1");
        Player.Life = 5;
        Player.Score = 0;
        Player.Shield = false;
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RestartToButton()
    {
        _buttonRestart.SetActive(true);
    }
}
