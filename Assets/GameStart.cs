using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public List<GameObject> inGameUIObjects;

    void Start()
    {
        PopulateInGameUIList();
    }

    void PopulateInGameUIList()
    {
        GameObject[] allObjects = GameObject.FindGameObjectsWithTag("inGameUI");
        inGameUIObjects = new List<GameObject>(allObjects);
        Debug.Log(allObjects);
        // Start is called before the first frame update
    }
        private void Update()
    {
            
        if (SceneManager.sceneCount == 1)
        {
           
            
          
            foreach (GameObject obj in inGameUIObjects)
            {
                Debug.Log(obj);
                if (obj is GameObject && !(((GameObject)obj).activeSelf) )
                {

                    obj.SetActive(true);

                }

            }
        }
    }
}
