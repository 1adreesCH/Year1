using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightCone : MonoBehaviour
{
    public bool enter = true;

    void OnTriggerEnter2D(Collider2D Main)
    {
        if (enter)
        print("Attack");
                       
    }
}
