using UnityEngine;

public class SceneMusic : MonoBehaviour
{
    private void Start()
    {
       AudioManager.instance.Play("Background_Music");
    }    
}
