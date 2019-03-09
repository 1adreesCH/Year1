using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBar : MonoBehaviour
{
    public static ItemBar instance;
    public GameObject smallKeyCard;
    public GameObject bigKeyCard;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public void SKC()
    {
        smallKeyCard.SetActive(true);
    }

    public void BKC()
    {
        bigKeyCard.SetActive(true);
    }
}
