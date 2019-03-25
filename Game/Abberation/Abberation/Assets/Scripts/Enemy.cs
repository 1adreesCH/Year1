using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed;
    private float directionX;
    private float directionY;
    public bool horizontal;
    public bool vertical;
    //public bool circle;
    public Animator anim;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        anim.SetBool("moveright", false);
        anim.SetBool("moveleft", false);
        anim.SetBool("moveup", false);
        anim.SetBool("movedown", false);

        if (horizontal)
        {
            directionX = 1f;
            directionY = 0f;
        }

        else if (vertical)
        {
            directionX = 0f;
            directionY = 1f;
        }

    }

    void FixedUpdate()
    {

        if (horizontal)
        {
            float moveHorizontal = directionX;
            float moveVertical = directionY;
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.AddForce(movement * speed);


            if (directionX>0)
            {
                anim.SetBool("moveright", true);
                anim.SetBool("moveleft", false);
                anim.SetBool("moveup", false);
                anim.SetBool("movedown", false);
            }
            else if(directionX<0)
            {
                anim.SetBool("moveright", false);
                anim.SetBool("moveleft", true);
                anim.SetBool("moveup", false);
                anim.SetBool("movedown", false);
            }
        }

        else if (vertical)
        {
           float moveHorizontal = directionX;
           float moveVertical = directionY;
           Vector2 movement = new Vector2(moveHorizontal, moveVertical);
           rb2d.AddForce(movement * speed);


            if (directionY > 0)
            {
                anim.SetBool("moveright", false);
                anim.SetBool("moveleft", false);
                anim.SetBool("moveup", true);
                anim.SetBool("movedown", false);
            }
            else if (directionY < 0)
            {
                anim.SetBool("moveright", false);
                anim.SetBool("moveleft", false);
                anim.SetBool("moveup", false);
                anim.SetBool("movedown", true);
            }
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            directionX = -directionX;
        }

        if (vertical && other.gameObject.tag == "Wall")
        {
            directionY = -directionY;
        }

        if (other.gameObject.tag == "PlayerLaser")
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyLaser")
        {
            directionX = 0;
            directionY = 0;
        }


    }














}