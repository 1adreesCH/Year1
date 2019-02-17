using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed = 0.5f;
    public float directionX;
    public float directionY = 1f;
    private float direction;

    private void Start()
    {
    }

    private void FixedUpdate()
    {

        Vector3 position = transform.localPosition;
        position.y += speed * directionY;
        position.x += speed * directionX;
        transform.localPosition = position;

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);

        switch (other.gameObject.name)
        {
            case "Main":
               Destroy(other.gameObject);
               break;

        }
    }

}
