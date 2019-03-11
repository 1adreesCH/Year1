using System.Collections;
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
        //Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        //rb2d.AddForce(movement * speed);

        //if(moveHorizontal != 0)
        {
           // moveVertical = 0;
           // Vector2 movement = new Vector2(moveHorizontal, moveVertical);
           // rb2d.AddForce(movement * speed);
        }

       // if (moveVertical != 0)
        {
           // moveHorizontal = 0;
           // Vector2 movement = new Vector2(moveHorizontal, moveVertical);
           // rb2d.AddForce(movement * speed);
        }

       // if (moveHorizontal == 0 && moveVertical == 0)
        {
           // anim.SetBool("moveright", false);
           // anim.SetBool("moveleft", false);
           // anim.SetBool("moveup", false);
           // anim.SetBool("movedown", false);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            anim.SetBool("moveright", false);
            anim.SetBool("moveleft", false);
            anim.SetBool("moveup", true);
            anim.SetBool("movedown", false);

            moveHorizontal = 0;
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.AddForce(movement * speed);
        }

        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            anim.SetBool("moveright", false);
            anim.SetBool("moveleft", false);
            anim.SetBool("moveup", false);
            anim.SetBool("movedown", true);

            moveHorizontal = 0;
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.AddForce(movement * speed);
        }

        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            anim.SetBool("moveright", false);
            anim.SetBool("moveleft", true);
            anim.SetBool("moveup", false);
            anim.SetBool("movedown", false);

            moveVertical = 0;
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.AddForce(movement * speed);
        }

        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("moveright", true);
            anim.SetBool("moveleft", false);
            anim.SetBool("moveup", false);
            anim.SetBool("movedown", false);

            moveVertical = 0;
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

        if (other.gameObject.tag == "EnemyLaser")
        {
            life -= 1;
            PlayerPrefs.SetInt("life",life);
            GameController.instance.PlayerDied();
        }

        else if ((other.gameObject.tag == "Door") && bigKeyCard)
        {
            GameController.instance.LevelEnd();
            MainDoor.instance.OpenMainDoor();
            bigKeyCard = false;
        }

        switch (other.gameObject.name)
        {
            case "SmallKeyCard":
                smallKeyCard = true;
                Destroy(other.gameObject);
                ItemBar.instance.SKC();
                break;

            case "BigKeyCard":
                bigKeyCard = true;
                Destroy(other.gameObject);
                ItemBar.instance.BKC();
                break;
        }
    }

	void OnTriggerEnter2D(Collider2D other)
    {


    }
   
}
