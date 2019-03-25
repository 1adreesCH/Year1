using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallDoor : MonoBehaviour
{
    public static SmallDoor instance;
    public Animator anim;
    private SpriteRenderer sprite;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    void Start()
    {
        anim.ResetTrigger("OpenT");

        BoxCollider2D boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
        boxCollider2D.enabled = true;

        sprite = GetComponent<SpriteRenderer>();
        sprite.sortingOrder = 4;
    }


    public void OpenSmallDoor()
    {
        anim.SetTrigger("OpenT");

        BoxCollider2D boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
        boxCollider2D.enabled = false;
        sprite.sortingOrder = 5;
    }
}
