using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleted : MonoBehaviour
{
    public bool levelCompleted = false;
	public GameObject player;

    void Start()
    {
        levelCompleted = false;
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player" ) //&& Player.bigKeyCard)
        {
            Destroy(other.gameObject);
            levelCompleted = true;
            GameController.instance.LevelEnd();
        }

    }
}
