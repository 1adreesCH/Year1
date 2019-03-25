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
        // Switch to 640 x 480 full-screen
        //Screen.SetResolution(640, 480, true);
    }

    void Update()
    {
        if (gameover && Input.GetKey(KeyCode.Space))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(0);
        }

        else if (levelcomplete && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);           
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
