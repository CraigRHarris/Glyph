using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

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
    // Start is called before the first frame update
    void Start()
    {
        

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
<<<<<<< Updated upstream
        // Debug.Log(UpdateTime);
=======
        //Debug.Log(UpdateTime);
>>>>>>> Stashed changes

        // ending game
        if (UpdateTime <= 0)
        {
            // End Game
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
