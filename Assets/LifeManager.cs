using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour

{
    //hier staat er moet hoeveel levens de player begint
    public static int health = 4;
    
    public Image[] hearts;

    public Sprite fullHeart;

    public Sprite emptyHeart;
  
  //hier vervangt hij volle hartjes met lege hartjes als een player doodgaat
    void Update()
    {
        foreach (Image img in hearts)
        { 
            img.sprite = emptyHeart;
        }
        for (int i = 0; i < health; i++) 
        {
            hearts[i].sprite = fullHeart;
        }
    }
}
    

   
