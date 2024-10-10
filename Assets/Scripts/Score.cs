using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text ScoreText;
    public int trigger = 0;
    int score = 0;
    float timer;

    void Update()
    {
        if (trigger == 1)
        {
            score++;
            ScoreText.SetText(score.ToString());
            trigger = 0;
        }
        if (trigger == 2)
        {
            score +=5;
            ScoreText.SetText(score.ToString());
            trigger = 0;
        }
        timer += Time.deltaTime;
        if (timer > 1)
        {
            score++;
            ScoreText.SetText(score.ToString());
            timer = 0;
        }
    }
}