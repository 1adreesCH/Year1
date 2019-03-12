using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaser : MonoBehaviour
{
    public float speed;

    private void Start()
    {

    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);


    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }


}
