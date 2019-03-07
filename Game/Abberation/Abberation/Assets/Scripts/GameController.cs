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

    void Update()
    {
        if (gameover && Input.GetKey(KeyCode.R))
        {
            //change to boot to main menu
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
		// load next level
    }
}
