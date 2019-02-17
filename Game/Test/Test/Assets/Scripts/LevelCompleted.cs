using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleted : MonoBehaviour
{
    public bool levelCompleted = false;

    void Start()
    {
        levelCompleted = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            levelCompleted = true;
            GameController.instance.LevelEnd();
        }



    }
}
