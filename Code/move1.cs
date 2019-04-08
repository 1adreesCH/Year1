using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class move1 : MonoBehaviour
{

    private void Start()
    {
        PlayerPrefs.SetInt("life", 3);
    }

    public void changemenuscene()
    {
        SceneManager.LoadScene(1);
    }
}
