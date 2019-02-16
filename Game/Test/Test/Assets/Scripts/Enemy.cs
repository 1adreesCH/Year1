using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   
    public float speed;
    public float directionX;
    public float directionY;


    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 position = transform.localPosition;
        position.y += speed * directionY;
        transform.localPosition = position;



    }

    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            case "Wall":
                directionY = -directionY;
                transform.Rotate(180f, 0f, 0f);
                break;

        }
     }

    void OnTriggerEnter2D(Collider2D other)
    {

        switch (other.gameObject.name)
        {
            case "Main":
                print("Attack2");
                speed = 0;
                break;

        }


    }














}
