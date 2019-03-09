﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserSpawner : MonoBehaviour
{
    public GameObject PlayerLaser;
    public AudioClip SoundClip;
    public AudioSource SoundSource;
    public float timeDelay;
    private float timeDelayCounter;
    public bool canShoot;

    //public float rotateCounter;

    private void Start()
    {
        SoundSource.clip = SoundClip;
        canShoot = true;
        timeDelayCounter = timeDelay;

        //rotateCounter = 0;

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && canShoot )
        {
            Instantiate(PlayerLaser, transform.position, transform.rotation);
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


    
}
