using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemyLaserScript : MonoBehaviour
{
 

    public float speed;

    void Start()
    {


    }

    void FixedUpdate()
    {

        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);

        //switch (other.gameObject.name)
        //{
           // case "Main":
              //  Destroy(other.gameObject);
               // break;

        //}
    }
}
