using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoring : MonoBehaviour {
    public GameObject Scorebox;
    int score=0;
    Text txt;
    public void addscore(int sc)
    {
        
        score=score + sc;

        Scorebox.GetComponent<Text>().text = "Score: " +  score;
    }



    




}
