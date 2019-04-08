using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCone : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wall" || other.gameObject.tag == "SDoor")
        {           
            transform.Rotate(0f, 0f, 180f);
        }


    }
}
