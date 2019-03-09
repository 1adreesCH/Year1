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

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        smallKeyCard = false;
        bigKeyCard = false;
        life = PlayerPrefs.GetInt("life",life);

}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);

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
            //Destroy(other.gameObject);
            GameController.instance.LevelEnd();
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
