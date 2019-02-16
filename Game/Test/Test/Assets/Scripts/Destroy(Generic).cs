using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGeneric : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);// destroys other game object
        Destroy(gameObject);// destroys this game object
    }

}
