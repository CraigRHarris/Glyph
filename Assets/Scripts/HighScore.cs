using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HighScore : MonoBehaviour
{
    public TMP_Text ScoreText;
    private ValueStore StoreScript;
    private Score ScoreScript;

    void Start()
    {
        StoreScript = GameObject.Find("ValueStore").GetComponent<ValueStore>();
        ScoreScript = GameObject.Find("Score").GetComponent<Score>();
        ScoreText.SetText("High Score : " + StoreScript.score.ToString());
    }
    void Update()
    {
        if (ScoreScript.score > StoreScript.score)
        {
            StoreScript.score = ScoreScript.score;
        }
    }
}
