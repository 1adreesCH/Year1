using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    public float speed;
    public float directionX;
    public float directionY;


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
