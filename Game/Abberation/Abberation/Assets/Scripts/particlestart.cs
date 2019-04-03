using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlestart : penemy
{
    void Update()
    {
            Vector3 position2 = transform.localPosition;
            position2.y = posy;
            transform.localPosition = position2;
    }
}
