using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserSpawner : MonoBehaviour
{
    public GameObject EnemyLaser;

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
