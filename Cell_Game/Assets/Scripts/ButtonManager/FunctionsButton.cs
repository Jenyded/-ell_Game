using UnityEngine;
using UnityEngine.SceneManagement;

public class FunctionsButton : MonoBehaviour
{
    [SerializeField] private GameObject _buttonRestart;
    [SerializeField] private GameObject _pauseGameMenu;
    public bool PauseGame;
    public static FunctionsButton Instance;

    private void Awake()
    {
        Instance = this;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
                Resume();
            else
                Pause();
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Scene1");
        Player.Life = 5;
        Player.Score = 0;
        Player.Shield = false;
    }

    public void RestartToButton()
    {
        _buttonRestart.SetActive(true);
    }

    public void Resume()
    {
        _pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void Pause()
    {
        _pauseGameMenu.SetActive(true);
        Time.timeScale = 0;
        PauseGame = true;
    }

    public void LosdMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }   

    public void ResetHighScore()
    {
        ScoreCounter.ResetHighScore();
    }     
}
