using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed;
    public float directionX;
    public float directionY;
	public bool horizontal;
	public bool vertical;
	//public bool circle;

    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

	if (horizontal)
	{
		directionX=1f;
		directionY=0f;
		float moveHorizontal = directionX;
		float moveVertical = directionY;
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		rb2d.AddForce(movement * speed);
	}
		else if (vertical)
	{
		directionX=0f;
		directionY=1f;
		float moveHorizontal = directionX;
		float moveVertical = directionY;
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		rb2d.AddForce(movement * speed);
	}

    }

    void OnCollisionEnter2D(Collision2D other)
    {
			if (horizontal && other.gameObject.tag == "Wall")
			{
			    directionX = -directionX;
                transform.Rotate(180f, 0f, 0f);   
			}
						
			else if (vertical && other.gameObject.tag == "Wall")
			{
			    directionY = -directionY;
                transform.Rotate(180f, 0f, 0f);   
			}
			
			else if (other.gameObject.tag == "PlayerLaser")
			{
			
			life=-1;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

			}

     }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.name)
        {
            case "Player":
                speed = 0;
                break;
        }


    }














}
