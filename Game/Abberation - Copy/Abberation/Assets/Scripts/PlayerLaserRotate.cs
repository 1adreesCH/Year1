using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserRotate : MonoBehaviour

{
    private Quaternion rot0;

    void Start()
    {
        rot0 = transform.rotation;
    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.rotation = rot0;
            transform.Rotate(0f, 0f, 0f);
        }

        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.rotation = rot0;
            transform.Rotate(0f, 0f, 180f);
        }

        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.rotation = rot0;
            transform.Rotate(0f, 0f, 90f);
        }

        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.rotation = rot0;
            transform.Rotate(0f, 0f, 270f);
        }
        
    }
}
