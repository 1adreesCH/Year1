using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBar : MonoBehaviour
{
    public static LifeBar instance;
    public GameObject life1;
    public GameObject life2;
    //public GameObject life3;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public void LostOneLife()
    {
        life1.SetActive(false);
    }

    public void LostTwoLives()
    {
        life2.SetActive(false);
    }

   // public void LostThreeLives()
   // {

   // }

}
