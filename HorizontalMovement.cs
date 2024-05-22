using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{ 
    void Update()
    {
        transform.Rotate(0, .20f, 0);
    }
}