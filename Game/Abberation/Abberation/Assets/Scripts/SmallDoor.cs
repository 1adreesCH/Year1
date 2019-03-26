using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallDoor : MonoBehaviour
{
    public static SmallDoor instance;
    public Animator anim;
    private SpriteRenderer sprite;
    private float timedelay;
    public bool open;

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

        timedelay = 0.6f;
        open = false;

    }

    private void FixedUpdate()
    {

        if (open)
        {
            timedelay -= Time.deltaTime;

            if (timedelay <= 0)
            {
                BoxCollider2D boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
                boxCollider2D.enabled = false;
                sprite.sortingOrder = 6;
                open = false;
            }
        }

    }


    public void OpenSmallDoor()
    {
        anim.SetTrigger("OpenT");
        open = true;
    }
}
