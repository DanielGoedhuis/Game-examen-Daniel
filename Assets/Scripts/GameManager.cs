using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Gameover;
    public GameObject GameOverUI;


    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void restart()
    {
        LifeManager.health = 4;
        SceneManager.LoadScene(0);
        SceneManager.LoadScene(1);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene( 0, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(2);
    }
}
