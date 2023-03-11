using UnityEngine;
using UnityEngine.SceneManagement;

public class FunctionsButton : MonoBehaviour
{
    public bool PauseGame;
    public static FunctionsButton Instance;
    [SerializeField] private GameObject _buttonPauseGameMenu;
    [SerializeField] private GameObject _buttonRestart;
    [SerializeField] private GameObject _buttonSwitchLevel;

    private void Awake()
    {
        Instance = this;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
                Continue();
            else
                Pause();
        }
    } 
    
    public void SetActiveButtonRestart()
    {
        _buttonRestart.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Scene1");
        Player.Life = 5;
        Player.Score = 0;
        Player.Shield = false;
    }

    public void Pause()
    {
        _buttonPauseGameMenu.SetActive(true);
        Time.timeScale = 0;
        PauseGame = true;
        AudioManager.instance.Stop("Background_Music");
    }  
    
    public void Continue()
    {
        _buttonPauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
        AudioManager.instance.Play("Background_Music");
    }
    public void ResetHighScore()
    {
        ScoreCounter.ResetHighScore();
    }

    public void LosdMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void SetActiveButtonSwitchLevel()
    {
        _buttonSwitchLevel.SetActive(true);
        Time.timeScale = 0;
        PauseGame = true;
        UIButton.Instance.ReflectLevel();
    }

    public void SwitchLevel()
    {
        SceneManager.LoadScene("Scene1");
        LevelsData.SwitchLevel();
        Time.timeScale = 1f;
        PauseGame = false;
    }
}
