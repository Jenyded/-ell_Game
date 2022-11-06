using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCylinderRotation : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0f, 2f, 0f); 
    }    
}
