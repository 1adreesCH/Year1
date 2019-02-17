using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameOverText;
    public GameObject levelCompleteText;
    public bool gameover = false;
    public bool levelcomplete = false;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        gameover = false;
        levelcomplete = false;
    }

    // Update is called once per frame
    void Update()
    {
        //If the game is over and the player has pressed some input...
        if (gameover && Input.GetKey(KeyCode.R))
        {
            //...reload the current scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void PlayerDied()
    {
        gameOverText.SetActive(true);
        gameover = true;
    }

    public void LevelEnd()
    {
        levelCompleteText.SetActive(true);
        levelcomplete = true;
    }
}
