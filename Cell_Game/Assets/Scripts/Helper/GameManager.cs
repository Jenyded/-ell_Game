using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private CreatingObject CreatingObject;
    [SerializeField] private BackgroundGame backgroundGame;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    private void Start()
    {
        LevelsData.Init();
        CreatingObject.Init(LevelsData.Levels[0]);
        backgroundGame.Init(LevelsData.Levels[LevelsData.CurentLevel]);
    }    

    public void SwitchLevel()
    {
        LevelsData.CurentLevel++;        
    }
}
