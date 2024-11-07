using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    //public GameObject spawnObject;
    private AudioManager audioManager;
    public GameObject gameOverGroup;

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        gameOverGroup.SetActive(false);
    }

    public void GameOver()
    {
        //spawnObject.GetComponent<spawnScriptName>().enabled = false;
        //audioManager.PlaySFX(gameOverSFX);
        //audioManager.PlayMusic(gameOverMusic);
        gameOverGroup.SetActive(true);

    }
}
