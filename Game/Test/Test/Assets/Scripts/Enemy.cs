using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speedY = 0.05f;
    float directionY = 1.0f;

    void Start()
    {

    }

    void Update()
    {


    }

    void FixedUpdate()
    {
        Vector3 position = transform.localPosition;
        position.y += speedY * directionY;
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
}
