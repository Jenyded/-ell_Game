using UnityEngine;
using UnityEngine.SceneManagement;

public class FunctionsButton : MonoBehaviour
{
    public bool IsPauseGame;
    public static FunctionsButton Instance;
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _panelPause;
    [SerializeField] private GameObject _buttonRestart;
    [SerializeField] private GameObject _buttonSwitchLevel;
    [SerializeField] private DoTweenWindow doTweenWindow;


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
    
    public void SetActiveButtonRestart()
    {
       // ADSRunning.Instance.ASD(); //reklam
        _buttonRestart.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Scene1");
        Player.Life = 5;
        Player.Score = 0;
        Player.IsShield = false;
    }

    public void Pause()
    {
        _pauseMenu.SetActive(true);
        _panelPause.SetActive(true);
        //Time.timeScale = 0;
        //IsPauseGame = true;
        AudioManager.instance.Stop("Background_Music");
        //doTweenWindow.AnimationInPopups().OnComplete(() => {Time.timeScale = 0;}); //!!!!
    }

    public void Continue()
    {
        Invoke("СloseWindowContinue", 0.3f);
        //_panelPause.SetActive(false);
        //_buttonPauseGameMenu.SetActive(false);
        //Time.timeScale = 1f;
        //IsPauseGame = false;
        AudioManager.instance.Play("Background_Music");
    }
    public void ResetHighScore()
    {
        ScoreCounter.ResetHighScore();
    }

    public void LosdMenu()
    {
        //Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void SetActiveButtonSwitchLevel()
    {
        AudioManager.instance.Stop("Background_Music");
        _buttonSwitchLevel.SetActive(true);
        //Time.timeScale = 0;
        //IsPauseGame = true;
        UIButton.Instance.ReflectLevel();
        AudioManager.instance.Play("Sound_Victory");
    }

    public void SwitchLevel()
    {
        SceneManager.LoadScene("Scene1");
        GameManager.Instance.SwitchLevel();
        //Time.timeScale = 1f;
        //IsPauseGame = false;
        Shield.IsShieldActivity = false;
        AudioManager.instance.Play("Background_Music");
    }
    
    public void СloseWindowContinue()
    {
        _pauseMenu.SetActive(false);
        _panelPause.SetActive(false);
    }
}
