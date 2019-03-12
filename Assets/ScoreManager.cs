using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    public static int score;
    Text text;
    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
    }
}
