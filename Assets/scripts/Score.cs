using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    static Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ""+scoreValue;
    }

    public static void Increase(int amount){
        int scores = Int32.Parse(score.text);
        scoreValue = (scores + amount) ;
    }
}
