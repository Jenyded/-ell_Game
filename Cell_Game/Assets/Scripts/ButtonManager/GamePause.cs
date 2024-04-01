using UnityEngine;

public class GamePause : MonoBehaviour
{
    public bool IsPaused { get; private set; }
    public static GamePause instance;

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(this);
        else
            instance = this;
    }

    private void OnDestroy()
    {
        if (instance == this) 
            instance = null;
    }

    public void SetPause(bool isEnable)
    {
        IsPaused = isEnable;
    }
}
