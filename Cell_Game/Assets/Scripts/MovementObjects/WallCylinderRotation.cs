using UnityEngine;

public class WallCylinderRotation : MonoBehaviour
{
    void FixedUpdate()
    {
        if (GamePause.instance.IsPaused)
        {
            return;
        }
        transform.Rotate(0f, 2f, 0f); 
    }    
}
