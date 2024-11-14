using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SurvivalMeter : MonoBehaviour
{
    // reference to slider
    public Slider Slider;
    // timer
    public float SurvivalTimer = 10.0f;

    // swipe inputs
    public float CorrectSwipe = 2.5f;
    public float IncorrectSwipe = 1.5f;

    public int trigger = 0;

    private float CurrentTime;
    private float UpdateTime;

    //private GameOver gameOverScript;
    private AudioManager audioManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        //gameOverScript = GetComponent<GameOver>();
        //audioManagerScript = GetComponent<AudioManager>();
        audioManagerScript = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

        //Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // update timer
        CurrentTime = Time.time;
        // Debug.Log(CurrentTime);
        UpdateTime = SurvivalTimer - Time.time;

        // cap the timer
        if (UpdateTime > 10)
        {
            UpdateTime = 10;
        }

        if (UpdateTime <= 3)
        {
            //play ticking timer SFX, if update timer <= 0 stop playing ticking timer SFX, if update timer > 3 then stop playing ticking timer sfx
            //audioManagerScript.PlaySFX(tickingTimer);
        }

        // Debug.Log(UpdateTime);

        // ending game
        if (UpdateTime <= 0)
        {
            //Stop Gameplay by disabling the object spawner script
            //Show animation of losing + play sound effects
            //Show game over screen
            SceneManager.LoadScene("Ancient Door");
        }

        // if correct swipe increase timer
        if (trigger == 1)
        {
            if (UpdateTime == 10)
            {

            }
            else
            {
                SurvivalTimer = SurvivalTimer + CorrectSwipe;
            }
        }

        // if incorrect swipe decrease timer
        if (trigger == 2)
        {
            SurvivalTimer = SurvivalTimer - IncorrectSwipe;
        }

        // update slider
        Slider.value = UpdateTime;

        trigger = 0;
    }
}
