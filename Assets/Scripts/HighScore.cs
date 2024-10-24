using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HighScore : MonoBehaviour
{
    public TMP_Text ScoreText;
    //private ValueStore StoreScript;
    private Score ScoreScript;
    public int highScore;
    int score;

    void Start()
    {
        //StoreScript = GameObject.Find("ValueStore").GetComponent<ValueStore>();
        ScoreScript = GameObject.Find("Score").GetComponent<Score>();
        //highScore = StoreScript.score;
        ScoreText.SetText(highScore.ToString());
    }
    void Update()
    {
        score = ScoreScript.score;
        if (score > highScore)
        {
            highScore = score;
            ScoreText.SetText(highScore.ToString());
            //if (StoreScript.score < highScore);
            //{
                //StoreScript.score = highScore;
            //}
        }
    }
}
