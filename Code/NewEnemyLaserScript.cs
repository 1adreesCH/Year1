﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemyLaserScript : MonoBehaviour
{
 

    public float speed;

    void Start()
    {


    }

    void FixedUpdate()
    {

        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
}
