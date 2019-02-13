using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnalogue : MonoBehaviour
{

    public KeyCode moveLeftKey = KeyCode.LeftArrow;
    public KeyCode moveRightKey = KeyCode.RightArrow;
    public KeyCode moveUpKey = KeyCode.UpArrow;
    public KeyCode moveDownKey = KeyCode.DownArrow;
    bool canMoveLeft = true;
    bool canMoveRight = true;
    bool canMoveUp = true;
    bool canMoveDown = true;

    public float speedx = 0.2f;
    public float speedy = 0.2f;
    float directionx = 0.0f;
    float directiony = 0.0f;

    void FixedUpdate()
    {
        Vector3 position = transform.localPosition;
        position.x += speedx * directionx;
        position.y += speedy * directiony;
        transform.localPosition = position;
    }

    void Update()
    {
        bool isLeftPressed = Input.GetKey(moveLeftKey);
        bool isRightPressed = Input.GetKey(moveRightKey);
        bool isUpPressed = Input.GetKey(moveUpKey);
        bool isDownPressed = Input.GetKey(moveDownKey);

        if (isLeftPressed && canMoveLeft)
        {
            directionx = -1.0f;
        }
        else if (isRightPressed && canMoveRight)
        {
            directionx = 1.0f;
        }
        else if (isUpPressed && canMoveUp)
        {
            directiony = 1.0f;
        }
        else if (isDownPressed && canMoveDown)
        {
            directiony = -1.0f;
        }
        else
        {
            directionx = 0.0f;
            directiony = 0.0f;
        }
    }
}
