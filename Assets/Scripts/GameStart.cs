using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject GameOverUI;
    //kijk of de game gestart is en zoja activeert het bepaalde gameobjecten die nodig zijn
    private void Update()
    {
        Scene Active = SceneManager.GetActiveScene();
        if (SceneManager.sceneCount == 1)
        {
           
            Object[] allObjects = Resources.FindObjectsOfTypeAll<GameObject>();
          
            foreach (GameObject obj in allObjects)
            {
                if (obj.CompareTag("inGameUI")){
                    
                    obj.SetActive(true);

                }

            }
        }
    }
}
