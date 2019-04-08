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
    private float timedelay;
    public bool death;
    private SpriteRenderer sprite;
    public GameObject sightcone;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        anim.SetBool("moveright", false);
        anim.SetBool("moveleft", false);
        anim.SetBool("moveup", false);
        anim.SetBool("movedown", false);
        anim.SetBool("Death 0", false);
        BoxCollider2D boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
        boxCollider2D.enabled = true;
        sprite = GetComponent<SpriteRenderer>();
        timedelay = 1f;

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

        death = false;

    }

    void FixedUpdate()
    {

        if (horizontal)
        {
            float moveHorizontal = directionX;
            float moveVertical = directionY;
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.AddForce(movement * speed);


            if (directionX > 0)
            {
                anim.SetBool("moveright", true);
                anim.SetBool("moveleft", false);
                anim.SetBool("moveup", false);
                anim.SetBool("movedown", false);
            }
            else if (directionX < 0)
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

        if (death)
        {
            timedelay -= Time.deltaTime;
            speed = 0;
            BoxCollider2D boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
            boxCollider2D.enabled = false;

            anim.SetBool("moveright", false);
            anim.SetBool("moveleft", false);
            anim.SetBool("moveup", false);
            anim.SetBool("movedown", false);

            if (timedelay <= 0)
            {
                Destroy(gameObject);
            }
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (horizontal && (other.gameObject.tag == "Wall" || other.gameObject.tag == "SDoor"))
        {
            directionX = -directionX;
        }

        if (vertical && (other.gameObject.tag == "Wall" || other.gameObject.tag == "SDoor"))
        {
            directionY = -directionY;
        }

        if (other.gameObject.tag == "PlayerLaser")
        {
            anim.SetBool("Death 0", true);
            death = true;

            anim.SetBool("moveright", false);
            anim.SetBool("moveleft", false);
            anim.SetBool("moveup", false);
            anim.SetBool("movedown", false);
            sightcone.SetActive(false);
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