using UnityEngine;
using UnityEngine.SceneManagement;

public class FunctionsButton : MonoBehaviour
{
    [SerializeField] private GameObject _buttonStart;
    [SerializeField] private GameObject _buttonExit;
    [SerializeField] private GameObject _buttonSound;

    [SerializeField] private GameObject _buttonRestart;
    [SerializeField] private GameObject _buttonExitToMenu;
    
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }  
    
    public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }
    
    public void RestartLevel()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
