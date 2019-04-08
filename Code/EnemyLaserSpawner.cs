using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserSpawner : MonoBehaviour
{
    public GameObject EnemyLaser;
    public AudioClip SoundClip;
    public AudioSource SoundSource;
    public float timeDelay;
    private float timeDelayCounter;
    public bool canShoot;
    private bool fire;


    private void Start()
    {
        SoundSource.clip = SoundClip;
        canShoot = true;
        timeDelayCounter = timeDelay;
        fire = false;
    }
    private void FixedUpdate()
    {
        if (fire && canShoot)
        {
            Instantiate(EnemyLaser, transform.position, transform.rotation);
            SoundSource.Play();
            canShoot = false;
        }

        if (!canShoot)
        {
            timeDelayCounter -= Time.deltaTime;
            if (timeDelayCounter <= 0)
            {
                canShoot = true;
                timeDelayCounter = timeDelay;
            }
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            fire = true;
        }
    }

}

    





