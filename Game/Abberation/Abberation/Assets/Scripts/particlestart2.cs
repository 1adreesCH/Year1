using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlestart2 : enemy2
{
    void Update()
    {
            Vector3 position2 = transform.localPosition;
            position2.x = posx;
            position2.y = posy;
            transform.localPosition = position2;
    }
}
