using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoor : MonoBehaviour
{
    public static MainDoor instance;
    public Animator anim;

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

       // BoxCollider2D boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
       // boxCollider2D.enabled = true;
    }


    public void OpenMainDoor()
    {
        anim.SetTrigger("OpenT");

       // BoxCollider2D boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
       // boxCollider2D.enabled = false;
    }
}
