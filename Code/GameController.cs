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
    private bool levelcomplete;


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
        levelcomplete = false;
    }

    void Update()
    {
        if (gameover && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }

        else if (levelcomplete && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);           
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
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
        levelcomplete = true;

		
    }
}
