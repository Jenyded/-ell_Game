using UnityEngine;

public class WallCylinderRotation : MonoBehaviour
{
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate00000000000");
        if (GamePause.instance.IsPaused)
        {
            return;
        }
        transform.Rotate(0f, 2f, 0f); 
    }    
}
