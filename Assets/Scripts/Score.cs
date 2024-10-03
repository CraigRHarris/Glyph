using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text ScoreText;
    public int trigger = 0;
    int score = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if(trigger == 1)
        {
            score++;
            ScoreText.SetText(score.ToString());
            trigger = 0;
        }
    }
}
