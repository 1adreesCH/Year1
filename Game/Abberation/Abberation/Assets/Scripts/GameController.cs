using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameOverText;
    public GameObject levelCompleteText;
    private bool gameover;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    private void Start()
    {
        gameover = false;
    }

    void Update()
    {
        if (gameover && Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //change to boot to main menu
        }
    }

    public void PlayerDied()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        gameover = true;

    }

    public void LevelEnd()
    {
        levelCompleteText.SetActive(true);

		// load next level
    }
}
