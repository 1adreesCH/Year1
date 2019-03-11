using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class enemy : MonoBehaviour
{
    public Animator anim;
    float directiony = -1.0f;
    int count = 1;
    float speed = 0.01f;
    void FixedUpdate()
    {
        Vector3 position = transform.localPosition;
        position.y += speed * directiony;
        transform.localPosition = position;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            case "Wall":
                if (count == 1)
                {
                    anim.SetBool("swap1", false);
                    anim.SetBool("swap2", false);
                    directiony = 1.0f;
                    anim.SetBool("swap1", true);
                    count = 2;
                }
                else if (count == 2)
                {
                    anim.SetBool("swap1", false);
                    anim.SetBool("swap2", false);
                    directiony = -1.0f;
                    anim.SetBool("swap2", true);
                    count = 1;
                }
                break;
        }
    }
 
}
