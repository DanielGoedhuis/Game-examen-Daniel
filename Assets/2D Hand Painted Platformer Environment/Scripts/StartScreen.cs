using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{

    private void Start()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene Name: " + activeScene.name);
        Debug.Log("Active Scene Build Index: " + activeScene.buildIndex);
        Debug.Log("Active Scene Path: " + activeScene.path);
    }


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

