using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Use this for initialization
    public bool rotatereverse = true;
    public bool reverse = false;
    public int count = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rotatereverse == false)
        {
            transform.Rotate(0, 0, 1);
            count = count + 1;
            if (reverse == true)
            {
                if (count == 180)
                {
                    rotatereverse = true;
                    count = 0;
                }
            }
            else if (reverse == false)
            {
                if (count == 90)
                {
                    rotatereverse = true;
                    count = 0;
                }
            }
        }
        else if (rotatereverse == true)
        {
            transform.Rotate(0, 0, -1);
            count = count + 1;
            if (count == 180)
            {
                rotatereverse = false;
                count = 0;
                reverse = true;
            }
            
        }
    }
}
