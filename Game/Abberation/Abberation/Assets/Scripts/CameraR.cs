using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraR : MonoBehaviour
{
    private bool canRotate;
    public int maxAngle;
    private int count;

    void Start()
    {
        count = 0;
    }

    void FixedUpdate()
    {
        if (canRotate)
        {
            transform.Rotate(0, 0, 1);
            count = count + 1;

            if (count >= maxAngle)
            {
                canRotate = false;
                count = 0;
            }
        }

        else if (!canRotate)
        {
            transform.Rotate(0, 0, -1);
            count = count + 1;

            if (count >= maxAngle)
            {
                canRotate = true;
                count = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }

    }


}
