using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float playerSpeed = 10f;
    float yValue;

    // Start is called before the first frame update (happens once)
    void Start()
    {
        SetValueY();
        PrintInstructions();
    }

    void Update()
    {
        PlayerMovement();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to Cap-Hop!");
        Debug.Log("You can move the capsule through either using WASD or the arrow keys.");
        Debug.Log("Try not to fall off the stage!");
    }
    void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;
        transform.Translate(xValue, yValue, zValue);
    }

    void SetValueY()
    {
        yValue = 0f;
    }
}