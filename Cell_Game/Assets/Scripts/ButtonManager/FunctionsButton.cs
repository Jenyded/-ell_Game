using UnityEngine;
using UnityEngine.SceneManagement;

public class FunctionsButton : MonoBehaviour
{
    public bool IsPauseGame;
    public static FunctionsButton Instance;
    public InterstitialReclam IntReclama; //для показа рекламы
    private int _countAttempts; //для показа рекламы
    [SerializeField] private GameObject _buttonPauseGameMenu;
    [SerializeField] private GameObject _buttonRestart;
    [SerializeField] private GameObject _buttonSwitchLevel;


    private void Awake()
    {
        Instance = this;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPauseGame)
                Continue();
            else
                Pause();
        }
    }

    private void Start()
    {
        _countAttempts = PlayerPrefs.GetInt("Count_Losses"); //для рекламы
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
        Player.IsShield = false;
        _countAttempts += 1; //для рекламы
        PlayerPrefs.SetInt("Count_Losses", _countAttempts); //для рекламы
        if (PlayerPrefs.GetInt("Count_Losses") == 3) //для рекламы
        {
            IntReclama.Show();
            PlayerPrefs.SetInt("Count_Losses", 0);
        }
    }

    public void Pause()
    {
        _buttonPauseGameMenu.SetActive(true);
        Time.timeScale = 0;
        IsPauseGame = true;
        AudioManager.instance.Stop("Background_Music");
    }

    public void Continue()
    {
        _buttonPauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        IsPauseGame = false;
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
        AudioManager.instance.Stop("Background_Music");
        _buttonSwitchLevel.SetActive(true);
        Time.timeScale = 0;
        IsPauseGame = true;
        UIButton.Instance.ReflectLevel();
        AudioManager.instance.Play("Sound_Victory");
    }

    public void SwitchLevel()
    {
        SceneManager.LoadScene("Scene1");
        GameManager.Instance.SwitchLevel();
        Time.timeScale = 1f;
        IsPauseGame = false;
        AudioManager.instance.Play("Background_Music");
    }
}
