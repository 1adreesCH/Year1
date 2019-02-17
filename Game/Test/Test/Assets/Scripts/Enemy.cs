using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb2d;
    //public GameObject main;
    public float speed;
    public float directionX;
    public float directionY;

    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
       float moveHorizontal = directionX;
       float moveVertical = directionY;
       Vector2 movement = new Vector2(moveHorizontal, moveVertical);
       rb2d.AddForce(movement * speed);

        //Vector3 position = transform.localPosition;
       // position.y += speed * directionY;
        //position.x += speed * directionX;
        //transform.localPosition = position;

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //void OnCollisionEnter(Collision collision)
       // {
           // if (collision.gameObject.tag == "theobjectToIgnore")
           // {
              //  Physics.IgnoreCollision(theobjectToIgnore.collider, collider);
           // }

            switch (other.gameObject.name)
        {
            case "Wall":
                directionY = -directionY;
                transform.Rotate(180f, 0f, 0f);           
                break;

            //case "Main":
                //Physics2D.IgnoreCollision(main.GetComponent<Collider2D>(), GetComponent<Collider2D>());
               // break;

            }
     }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.name)
        {
            case "Main":
                speed = 0;
                break;
        }


    }














}
