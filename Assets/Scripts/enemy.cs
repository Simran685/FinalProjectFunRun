using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class enemy : MonoBehaviour {

    public GameObject target;
    public float delay=0.05f;
    AudioSource PlayerDeath;
    public GameObject playerdying;
   



    public float fixeddistance =0.5f;
    void Start()
    {
   
            AudioSource[]
            audioSources = GetComponents<AudioSource>();
            PlayerDeath = audioSources[0];
     
    }
    void Update()
    {
        Vector3 distancefromplayer = target.transform.position - transform.position;
        float magOfDistancefromplayer= distancefromplayer.magnitude;
        Vector3 distancefromplayerN = distancefromplayer.normalized;
        if (magOfDistancefromplayer <= fixeddistance)
        {
            //gameObject.transform.Translate(distancefromplayer);
            transform.Translate(distancefromplayerN.x*0.09f, 0, 0);
        }

    }

   void OnTriggerEnter2D(Collider2D col)
   {
      
       if (col.gameObject.layer == LayerMask.NameToLayer("Player"))
       {
            Destroy(col.gameObject);
            col.gameObject.GetComponent<Animator>().SetTrigger("isDying");
            GameObject.Find("PlayerDeath").GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("gameoverScene");
        
         

            //Destroy(col.gameObject, col.gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);

        }

    }
  
}   
