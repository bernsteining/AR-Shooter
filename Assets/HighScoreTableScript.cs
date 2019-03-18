using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTableScript : MonoBehaviour
{

    public Text score1; public Text name1;
    public Text score2; public Text name2;
    public Text score3; public Text name3;
    public Text score4; public Text name4;
    public Text score5; public Text name5;
    public Text score6; public Text name6;
    public Text score7; public Text name7;
    public Text score8; public Text name8;
    public Text score9; public Text name9;
    public Text score10; public Text name10;

    // Start is called before the first frame update
    void Start()
    {

        int score = PlayerPrefs.GetInt("score");

        if (score >= PlayerPrefs.GetInt("1")){

            PlayerPrefs.SetInt("10", PlayerPrefs.GetInt("9")); PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name10"));
            PlayerPrefs.SetInt("9", PlayerPrefs.GetInt("8")); PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
            PlayerPrefs.SetInt("8", PlayerPrefs.GetInt("7")); PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
            PlayerPrefs.SetInt("7", PlayerPrefs.GetInt("6")); PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
            PlayerPrefs.SetInt("6", PlayerPrefs.GetInt("5"));
            PlayerPrefs.SetInt("5", PlayerPrefs.GetInt("4"));
            PlayerPrefs.SetInt("4", PlayerPrefs.GetInt("3"));
            PlayerPrefs.SetInt("3", PlayerPrefs.GetInt("2"));
            PlayerPrefs.SetInt("2", PlayerPrefs.GetInt("1"));

            PlayerPrefs.SetInt("1", score);

            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));
            PlayerPrefs.SetString("name2", PlayerPrefs.GetString("name1"));
            PlayerPrefs.SetString("name1", PlayerPrefs.GetString("username"));
       
        }

        if (score < PlayerPrefs.GetInt("1") && PlayerPrefs.GetInt("score")> PlayerPrefs.GetInt("2"))
        {
            PlayerPrefs.SetInt("10", PlayerPrefs.GetInt("9")); PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name10"));
            PlayerPrefs.SetInt("9", PlayerPrefs.GetInt("8")); PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
            PlayerPrefs.SetInt("8", PlayerPrefs.GetInt("7")); PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
            PlayerPrefs.SetInt("7", PlayerPrefs.GetInt("6")); PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
            PlayerPrefs.SetInt("6", PlayerPrefs.GetInt("5")); PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));
            PlayerPrefs.SetInt("5", PlayerPrefs.GetInt("4")); PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
            PlayerPrefs.SetInt("4", PlayerPrefs.GetInt("3")); PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
            PlayerPrefs.SetInt("3", PlayerPrefs.GetInt("2")); PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));
            PlayerPrefs.SetInt("2", PlayerPrefs.GetInt("score")); PlayerPrefs.SetString("name2", PlayerPrefs.GetString("username"));

        }

        if (score < PlayerPrefs.GetInt("2") && PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("3"))
        {
            PlayerPrefs.SetInt("10", PlayerPrefs.GetInt("9")); PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name10"));
            PlayerPrefs.SetInt("9", PlayerPrefs.GetInt("8")); PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
            PlayerPrefs.SetInt("8", PlayerPrefs.GetInt("7")); PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
            PlayerPrefs.SetInt("7", PlayerPrefs.GetInt("6")); PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
            PlayerPrefs.SetInt("6", PlayerPrefs.GetInt("5")); PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));
            PlayerPrefs.SetInt("5", PlayerPrefs.GetInt("4")); PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
            PlayerPrefs.SetInt("4", PlayerPrefs.GetInt("3")); PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
            PlayerPrefs.SetInt("3", PlayerPrefs.GetInt("score")); PlayerPrefs.SetString("name3", PlayerPrefs.GetString("username"));

        }

        if (score < PlayerPrefs.GetInt("2") && PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("3"))
        {
            PlayerPrefs.SetInt("10", PlayerPrefs.GetInt("9")); PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name10"));
            PlayerPrefs.SetInt("9", PlayerPrefs.GetInt("8")); PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
            PlayerPrefs.SetInt("8", PlayerPrefs.GetInt("7")); PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
            PlayerPrefs.SetInt("7", PlayerPrefs.GetInt("6")); PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
            PlayerPrefs.SetInt("6", PlayerPrefs.GetInt("5")); PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));
            PlayerPrefs.SetInt("5", PlayerPrefs.GetInt("4")); PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
            PlayerPrefs.SetInt("4", PlayerPrefs.GetInt("3")); PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
            PlayerPrefs.SetInt("3", PlayerPrefs.GetInt("score")); PlayerPrefs.SetString("name3", PlayerPrefs.GetString("username"));

        }

        if (score < PlayerPrefs.GetInt("3") && PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("4"))
        {
            PlayerPrefs.SetInt("10", PlayerPrefs.GetInt("9")); PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name10"));
            PlayerPrefs.SetInt("9", PlayerPrefs.GetInt("8")); PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
            PlayerPrefs.SetInt("8", PlayerPrefs.GetInt("7")); PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
            PlayerPrefs.SetInt("7", PlayerPrefs.GetInt("6")); PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
            PlayerPrefs.SetInt("6", PlayerPrefs.GetInt("5")); PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));
            PlayerPrefs.SetInt("5", PlayerPrefs.GetInt("4")); PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
            PlayerPrefs.SetInt("4", PlayerPrefs.GetInt("score")); PlayerPrefs.SetString("name4", PlayerPrefs.GetString("username"));

        }

        setValues();
    }

    private void setValues(){
        score1.text = PlayerPrefs.GetInt("1").ToString(); name1.text = PlayerPrefs.GetString("name1");
        score2.text = PlayerPrefs.GetInt("2").ToString(); name2.text = PlayerPrefs.GetString("name2");
        score3.text = PlayerPrefs.GetInt("3").ToString(); name3.text = PlayerPrefs.GetString("name3");
        score4.text = PlayerPrefs.GetInt("4").ToString(); name4.text = PlayerPrefs.GetString("name4");
        score5.text = PlayerPrefs.GetInt("5").ToString(); name5.text = PlayerPrefs.GetString("name5");
        score6.text = PlayerPrefs.GetInt("6").ToString(); name6.text = PlayerPrefs.GetString("name6");
        score7.text = PlayerPrefs.GetInt("7").ToString(); name7.text = PlayerPrefs.GetString("name7");
        score8.text = PlayerPrefs.GetInt("8").ToString(); name8.text = PlayerPrefs.GetString("name8");
        score9.text = PlayerPrefs.GetInt("9").ToString(); name9.text = PlayerPrefs.GetString("name9");
        score10.text = PlayerPrefs.GetInt("10").ToString(); name10.text = PlayerPrefs.GetString("name10");
    }
}
