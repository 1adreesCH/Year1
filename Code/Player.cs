﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
	private int life = 3;
	public bool smallKeyCard;
	public bool bigKeyCard;
    private Rigidbody2D rb2d;
    public Animator anim;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        smallKeyCard = false;
        bigKeyCard = false;
        life = PlayerPrefs.GetInt("life",life);
        anim.SetBool("moveright", false);
        anim.SetBool("moveleft", false);
        anim.SetBool("moveup", false);
        anim.SetBool("movedown", false);

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            anim.SetBool("moveright", false);
            anim.SetBool("moveleft", false);
            anim.SetBool("moveup", true);
            anim.SetBool("movedown", false);

            //moveHorizontal = 0;
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.AddForce(movement * speed);
        }

        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            anim.SetBool("moveright", false);
            anim.SetBool("moveleft", false);
            anim.SetBool("moveup", false);
            anim.SetBool("movedown", true);

            //moveHorizontal = 0;
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.AddForce(movement * speed);
        }

        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            anim.SetBool("moveright", false);
            anim.SetBool("moveleft", true);
            anim.SetBool("moveup", false);
            anim.SetBool("movedown", false);

            //moveVertical = 0;
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.AddForce(movement * speed);
        }

        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("moveright", true);
            anim.SetBool("moveleft", false);
            anim.SetBool("moveup", false);
            anim.SetBool("movedown", false);

            //moveVertical = 0;
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.AddForce(movement * speed);
        }

        else
        {
            anim.SetBool("moveright", false);
            anim.SetBool("moveleft", false);
            anim.SetBool("moveup", false);
            anim.SetBool("movedown", false);
        }

        if (life < 3)
        {
            LifeBar.instance.LostOneLife();
        }

        if (life < 2)
        {
            LifeBar.instance.LostTwoLives();
        }

        if (life <= 0)
        {
            Destroy(gameObject);
            PlayerPrefs.SetInt("life", 3);
            GameController.instance.GameOver();
            LifeBar.instance.LostThreeLives();
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "EnemyLaser" || other.gameObject.tag == "Enemy")
        {
            life -= 1;
            PlayerPrefs.SetInt("life", life);
            GameController.instance.PlayerDied();
        }

        if ((other.gameObject.tag == "Door") && bigKeyCard)
        {
            GameController.instance.LevelEnd();
            MainDoor.instance.OpenMainDoor();
            bigKeyCard = false;
            Destroy(gameObject);
        }

        if ((other.gameObject.tag == "SDoor") && smallKeyCard)
        {
            SmallDoor.instance.OpenSmallDoor();
            smallKeyCard = false;
            ItemBar.instance.NSKC();
        }


        if ((other.gameObject.tag == "SDoor2") && smallKeyCard)
        {
            SmallDoor2a.instance.OpenSmallDoor();
            smallKeyCard = false;
            ItemBar.instance.NSKC();
        }

        if ((other.gameObject.tag == "smallKeyCard"))
        {
            smallKeyCard = true;
            Destroy(other.gameObject);
            ItemBar.instance.SKC();
        }

        if ((other.gameObject.tag == "BigKeyCard"))
        {
            bigKeyCard = true;
            Destroy(other.gameObject);
            ItemBar.instance.BKC();
        }

    }

	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Camera")
        {
            life -= 1;
            PlayerPrefs.SetInt("life", life);
            GameController.instance.PlayerDied();
        }

    }
   
}
