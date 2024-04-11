using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    private GameManager gameManager;
    private LifeManager lifeManager;
    
    private void Start()
    {
      
    }
    private void Update()
    {
        if (!gameManager)
        {
            gameManager = FindObjectOfType<GameManager>();
            
        }
        if (!lifeManager)
        {
            lifeManager = FindObjectOfType<LifeManager>();
        }
    }


    //deze void zorgt ervoor dat we naar een nieuwe scene gaan als er op de start game knop wordt gedrukt.
    public void PlayGame()
    {
        LifeManager.health = 4;
        SceneManager.LoadScene(1);
    }
    // deze void sluit de applicatie als er op quit wordt gedrukt.
    public void QuitGame()
    {
        Application.Quit();
    }
}

