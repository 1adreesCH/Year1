using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speedY = 0.1f;
    float directionY = 1.0f;

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
                break;

        }

    }
}
