using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HighScore : MonoBehaviour
{
    public TMP_Text ScoreText;
    private ValueStore ValueStore;
    private Score Score;
    int highScore;
    int score;

    void Start()
    {
        ValueStore = GameObject.Find("ValueStore").GetComponent<ValueStore>();
        Score = GameObject.Find("Score").GetComponent<Score>();
        highScore = ValueStore.score;
        ScoreText.SetText(highScore.ToString());
    }
    void Update()
    {
        score = Score.score;
        if (score > highScore)
        {
            highScore = score;
            ScoreText.SetText(highScore.ToString());
            if (ValueStore.score < highScore);
            {
                ValueStore.score = highScore;
            }
        }
    }
}
