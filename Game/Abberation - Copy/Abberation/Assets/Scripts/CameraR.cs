using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraR : MonoBehaviour
{
    private bool canRotate;
    public int maxAngle;
    private int count;
    public float timeDelay;
    private float timeDelayCounter;
    public bool delay;

    void Start()
    {
        count = 0;
        delay = false;
        timeDelayCounter = timeDelay;
    }

    void FixedUpdate()
    {
        if(!delay)
        {
            timeDelayCounter -= Time.deltaTime;

            if (timeDelayCounter <= 0)
            {
                delay = true;
                timeDelayCounter = timeDelay;
            }
        }

        if (canRotate && delay)
        {
            transform.Rotate(0, 0, 1);
            count = count + 1;
            delay = false;

            if (count >= maxAngle)
            {
                canRotate = false;
                count = 0;
            }
        }

        else if (!canRotate && delay)
        {
            transform.Rotate(0, 0, -1);
            count = count + 1;
            delay = false;

            if (count >= maxAngle)
            {
                canRotate = true;
                count = 0;
            }
        }
    }



}
