using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private GameObject _buttonStart;
    [SerializeField] private GameObject _buttonExit;
    [SerializeField] private GameObject _buttonSound;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Player.Life = 5;
        Player.Score = 0;
        Player.Shield = false;
    }

    public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }

    public void Sound()
    {
        AudioManager.SoundPause();
    }
}
