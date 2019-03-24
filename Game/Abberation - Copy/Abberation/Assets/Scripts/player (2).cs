using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class playertwo : MonoBehaviour
{
    public Animator anim;

    public KeyCode moveRightKey = KeyCode.RightArrow; // creates a public KeyCode variable called moveRightKey and sets the value to KeyCode.RightArrow
    public KeyCode moveLeftKey = KeyCode.LeftArrow; // creates a public KeyCode variable called moveLeftKey and sets the value to KeyCode.LeftArrow
    bool canMoveRight = true; // creates a bool variable called canMoveRight and sets the value to true
    bool canMoveLeft = true; // creates a bool variable called canMoveLeft and sets the value to true
    public KeyCode moveUpKey = KeyCode.UpArrow;
    public KeyCode moveDownKey = KeyCode.DownArrow;
    bool canMoveUp = true;
    bool canMoveDown = true;
    float speed = 0.2f;
    float directionx = 0.0f; 
    float directiony = 0.0f;
    public Text gameOver;
    void FixedUpdate()
    {
        Vector3 position = transform.localPosition; // creates a vector3 variable called position and sets it to transform.localPosition
        position.x += speed * directionx; // sets position.x to position.x + speed * direction
        position.y += speed * directiony; // sets position.x to position.x + speed * direction
        transform.localPosition = position; // sets transform.localPosition
    }
    void Update()
    {
        bool isrightPressed = Input.GetKey(moveRightKey); // creates a bool variable isrightPressed and sets it to Input.GetKey(moveRightKey)
        bool isleftPressed = Input.GetKey(moveLeftKey); // creates a bool variable isleftPressed and sets it to Input.GetKey(moveLeftKey)
        bool isUpPressed = Input.GetKey(moveUpKey);
        bool isDownPressed = Input.GetKey(moveDownKey);
        if (isrightPressed && canMoveRight)
        {
            directionx = 1.0f; // sets direction to 1
            anim.SetBool("moveright", false);
            anim.SetBool("moveleft", false);
            anim.SetBool("moveup", false);
            anim.SetBool("movedown", false);
            anim.SetBool("moveright", true);
        }
        else if (isleftPressed && canMoveLeft)
        {
            directionx = -1.0f; // sets direction to -1
            anim.SetBool("moveright", false);
            anim.SetBool("moveleft", false);
            anim.SetBool("moveup", false);
            anim.SetBool("movedown", false);
            anim.SetBool("moveleft", true);
        }
        else if (isUpPressed && canMoveUp)
        {
            directiony = 1.0f;
            anim.SetBool("moveright", false);
            anim.SetBool("moveleft", false);
            anim.SetBool("moveup", false);
            anim.SetBool("movedown", false);
            anim.SetBool("moveup", true);
        }
        else if (isDownPressed && canMoveDown)
        {
            directiony = -1.0f;
            anim.SetBool("moveright", false);
            anim.SetBool("moveleft", false);
            anim.SetBool("moveup", false);
            anim.SetBool("movedown", false);
            anim.SetBool("movedown", true);
        }
        else
        {
            directionx = 0.0f; // sets direction to 0
            directiony = 0.0f;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            case "right wall":
                canMoveRight = false; // sets canMoveRight to false
                break;
            case "left wall":
                canMoveLeft = false; // sets canMoverLeft to false
                break;
            case "top wall":
                canMoveUp = false;
                break;
            case "bottom wall":
                canMoveDown = false;
                break;
            case "sight":
                gameOver.gameObject.SetActive(true);
                break;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            case "right wall":
                canMoveRight = true; // sets canMoveRight to true
                break;
            case "left wall":
                canMoveLeft = true; // sets canMoveLeft to true
                break;
            case "top wall":
                canMoveUp = true;
                break;
            case "bottom wall":
                canMoveDown = true;
                break;
        }
    }
}
