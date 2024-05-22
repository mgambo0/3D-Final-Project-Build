using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMovement : MonoBehaviour
{
    float jumpheight = 5f;
    Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {

        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            playerRB.AddForce(Vector3.up * jumpheight, ForceMode.Impulse);
        }
    }
}
