﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public float speed;
    public bool alive;
	public int life = 3;
	public bool smallKeyCard = false;
	public bool bigKeyCard = false;


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
            life = -1;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

        else if (life == 0)
        {
            Destroy(gameObject);
            alive = false;
            GameController.instance.PlayerDied();
        }
    }

	void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.name)
        {
            case "SmallKeyCard":
                smallKeyCard = true;
				Destroy(other.gameObject);
                break;
			
			case "BigKeyCard":
                bigKeyCard = true;
				Destroy(other.gameObject);
                break;
        }

    }
}
