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
    }


    public void OpenMainDoor()
    {

        anim.SetTrigger("OpenT");

    }
}
