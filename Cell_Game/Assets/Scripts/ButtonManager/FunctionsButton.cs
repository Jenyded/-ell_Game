using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class FunctionsButton : MonoBehaviour
{
    public bool IsPauseGame;
    public static FunctionsButton Instance;
    [SerializeField] private GameObject _buttonPauseGameMenu;
    [SerializeField] private GameObject _buttonRestart;
    [SerializeField] private GameObject _buttonSwitchLevel;
    //[SerializeField] private RectTransform _butonDoTween;//!!!!
    
    //private Tween _tween;//!!!!
    [SerializeField] private DoTween _doTween;


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
       // ADSRunning.Instance.ASD(); //реклама
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
        _buttonPauseGameMenu.SetActive(true);
        Time.timeScale = 0;
        IsPauseGame = true;
        AudioManager.instance.Stop("Background_Music");
        _doTween.AnimationInPopups();//!!!!
        /*_tween.Kill();
        _tween = _butonDoTween.DOLocalMove(new Vector3(-2.27f, 137f, 0), 1.5f); */
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
        Shield.IsShieldActivity = false;
        AudioManager.instance.Play("Background_Music");
    }
}
