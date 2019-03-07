﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserScript : MonoBehaviour
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
        Destroy(gameObject);

    }

	void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.name)
        {
            case "Player":
                Destroy(gameObject);
                break;
        }
}
