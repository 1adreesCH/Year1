using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserRotate : MonoBehaviour

{
    private bool up;
    private bool down;
    private bool left;
    private bool right;
    public float rotateCounter;

    void Start()
    {
        up = true;
        down = false;
        left = false;
        right = false;
        rotateCounter = 0;
    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            up = true;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            down = true;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            left = true;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            right = true;
        }
        else if (up)
        {
            transform.Rotate(0f, 0f, 0f);
            up = false;
        }
        else if (down)
        {
            transform.Rotate(0f, 0f, 180f);
            down = false;
        }
        else if (left)
        {
            transform.Rotate(0f, 0f, 90f);
            left = false;
        }
        else if (right)
        {
            transform.Rotate(0f, 0f, 270f);
            right = false;
        }
    }
}
