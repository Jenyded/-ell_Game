using UnityEngine;
using UnityEngine.SceneManagement; 

public class Restart : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Scene1");
    }
}
