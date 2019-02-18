using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserSpawner : MonoBehaviour
{
    public GameObject EnemyLaser;
    public AudioClip SoundClip;
    public AudioSource SoundSource;



    private void Start()
    {
        SoundSource.clip = SoundClip;
    }
    private void FixedUpdate()
    {

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(EnemyLaser, transform.position, transform.rotation);
            SoundSource.Play();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyLaser")
        {
            Instantiate(EnemyLaser, transform.position, transform.rotation);
            SoundSource.Play();
        }
    }

}

    





