using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text ScoreText;
    public int trigger = 0;
    public int score = 0;
    float timer;

    void Update()
    {
        if (trigger == 1)
        {
            score++;
            trigger = 0;
        }
        if (trigger == 2)
        {
            score +=5;
            trigger = 0;
        }
        timer += Time.deltaTime;
        if (timer > 1)
        {
            score++;
            timer = 0;
        }
        ScoreText.SetText("Score : " + score.ToString());
    }
}