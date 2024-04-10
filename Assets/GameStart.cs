using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

    // Start is called before the first frame update

    private void Update()
    {
        if (SceneManager.sceneCount == 1)
        {
            Object[] allObjects = Resources.FindObjectsOfTypeAll<GameObject>();
            GameObject[] appear = GameObject.FindGameObjectsWithTag("inGameUI");
            foreach (GameObject obj in allObjects)
            {

                if (obj is GameObject && !((GameObject)obj).activeSelf && appear != null)
                {

                    obj.SetActive(true);

                }

            }
        }
    }
}
