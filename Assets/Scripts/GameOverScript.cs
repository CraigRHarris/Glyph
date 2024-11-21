using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    //public GameObject spawnObject;
    private AudioManager audioManager;
    public GameObject gameOverGroup;
    public ValueStore valueStoreScript;
    public HighScore highScoreScript;
    public Score scoreScript;
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI scoreText;


    private void Start()
    {
        //audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        //gameOverGroup.SetActive(false);
    }

    public void GameOver()
    {
        //spawnObject.GetComponent<spawnScriptName>().enabled = false;
        //audioManager.PlaySFX(gameOverSFX);
        //audioManager.PlayMusic(gameOverMusic);
        //gameOverGroup.SetActive(true);
    }

    private void Update()
    {
        CheckObjectVisibility();
    }

    void CheckObjectVisibility()
    {
        if(gameOverGroup.activeSelf)
        {
            //highscoreText = "High Score: " + 
            scoreText.SetText("Score: " +(scoreScript.ScoreText.ToString()));
        }
    }
}
