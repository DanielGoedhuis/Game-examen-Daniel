using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class ItemCollector : MonoBehaviour
{
    public CoinManager cm;
    public AudioManager am;
    
    
    private void Awake()
    {
        am = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            cm.coinCount++;
            am.PlaySFX(am.coinCollect);
            
        }
    }
}
