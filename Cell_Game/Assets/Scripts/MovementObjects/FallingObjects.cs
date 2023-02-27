using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    private bool _isNeedUpdate = false;
    private float _fallSpeedPosY = 0f;
    private float _fallSpeedPosX = 0f;
    
    private void Update()
    {
        if (_isNeedUpdate == false)
        {
            return;
        }

        transform.position -= new Vector3(_fallSpeedPosX, _fallSpeedPosY * Time.deltaTime);
    }  
    
    public void Init(float fallSpeedPosY)
    {
        _fallSpeedPosY = fallSpeedPosY;
        _isNeedUpdate = true;
    }
}
