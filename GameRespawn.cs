using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRespawn : MonoBehaviour
{
    public float thershold;

    void FixedUpdate()
    { 
        if(transform.position.y < thershold)
        {
            transform.position = new Vector3(0.16f, 0.89f, -8.9f);
        }   
    }

}
