using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class coinCounter : MonoBehaviour {
    AudioSource coins;
  
    public int score;
    public void start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        coins = audioSources[0];

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        
        if (coll.gameObject.layer== LayerMask.NameToLayer("Player") ) 
        {
            
            GameObject.Find("Score").GetComponent<scoring>().addscore(score);
            GameObject.Find("coins").GetComponent<AudioSource>().Play();
            

            Destroy(gameObject);
        


        }
    }
    
}
