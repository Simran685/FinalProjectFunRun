using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondCounter : MonoBehaviour {
    AudioSource Woohoo;

    public int score;
    public void start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        Woohoo = audioSources[0];

    }
    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.layer == LayerMask.NameToLayer("Player"))
        {

            GameObject.Find("Score").GetComponent<scoring>().addscore(score);
            GameObject.Find("Woohoo").GetComponent<AudioSource>().Play();


            Destroy(gameObject);



        }
    }

}
