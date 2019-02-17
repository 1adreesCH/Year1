using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public bool alive;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        alive = true;

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "EnemyLaser")
        {
            Destroy(gameObject);
            alive = false;
            GameController.instance.PlayerDied();
        }



    }
}
