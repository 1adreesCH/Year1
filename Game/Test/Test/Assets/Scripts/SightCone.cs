﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightCone : MonoBehaviour
{
    Color c1 = Color.white;
    Color c2 = Color.red;
    

    private void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.name)
        {
            case "Main":
                print("Attack");
                LineRenderer lineRenderer = gameObject.GetComponent<LineRenderer>();
                lineRenderer.startColor = c1;
                lineRenderer.endColor = c2;
                break;

        }


    }
}
