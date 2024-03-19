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
        BarLevelTime.fillAmount = _creatingObject._countingLevelKey / 100;
        
        //_fillTime = _creatingObject._countingLevelKey / 100;
        //BarLevelTime.fillAmount = _fillTime;
    }
} 