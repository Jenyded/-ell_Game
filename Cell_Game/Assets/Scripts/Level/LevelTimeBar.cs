using UnityEngine;
using UnityEngine.UI;

public class LevelTimeBar : MonoBehaviour
{
    [SerializeField] private Image BarLevelTime;
    [SerializeField] private CreatingObject _creatingObject;

    
    private void Update()
    {
        LevelTime();
    }

    public void LevelTime()
    {
        BarLevelTime.fillAmount = _creatingObject._countingLevelKey / CreatingObject.IntervalCreationObj;
    }
}