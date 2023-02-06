using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    [SerializeField] private float _fallSpeed_y;
    private float _fallSpeed_x = 0f;
    
    void Update()
    {       
        transform.position -= new Vector3(_fallSpeed_x, _fallSpeed_y * Time.deltaTime);
    }    
}
