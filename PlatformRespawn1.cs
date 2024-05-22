using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRespawn1 : MonoBehaviour
{
    public float thershold;

    void FixedUpdate()
    {
        if (transform.position.y < thershold)
        {
            transform.position = new Vector3(-0.8346139f, -7.751003f, 50.95f);
        }
    }

}