using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEnemyLaserSpawner : MonoBehaviour
{
    public GameObject EnemyLaser;


    private void FixedUpdate()
    {

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(EnemyLaser, transform.position, transform.rotation);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyLaser")
        {
            Instantiate(EnemyLaser, transform.position, transform.rotation);
        }
    }

}
