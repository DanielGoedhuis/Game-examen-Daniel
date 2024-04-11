using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Gameover;
    public GameObject GameOverUI;

    private void Awake()
    {
       // DontDestroyOnLoad(Gameover);
    }

    public void LoadScene()
    {
        // Set the GameObject inactive before loading the scene
        //Gameover.SetActive(false);

        // Load the new scene
        //SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene( 0, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(2);
    }
}
