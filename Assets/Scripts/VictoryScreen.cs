using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{
    // zorgt ervoor dat we naar main menu kunnen
    public void mainMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(3);
    }


    // Quits the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
