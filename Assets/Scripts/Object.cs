using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Object : MonoBehaviour
{
    private Score ScoreScript;
    private MouseInput InputScript;
    private SurvivalMeter MeterScript;
    public string direction;
    float z = -10f;
    string input;

    void Start()
    {
        ScoreScript = GameObject.Find("Score").GetComponent<Score>();
        InputScript = GameObject.Find("Canvas").GetComponent<MouseInput>();
        MeterScript = GameObject.Find("Slider").GetComponent<SurvivalMeter>();
    }

    void Update()
    {
        z += 20 * Time.deltaTime;
        transform.position = new Vector3(0, 1, z);
        if (InputScript.input == direction)
        {
            input = "null";
            ScoreScript.trigger = 1;
            MeterScript.trigger = 1;
            Destroy(gameObject);
        }
        if (InputScript.input != direction & InputScript.input != input &(InputScript.input == "Right" | InputScript.input == "Left" | InputScript.input == "Up" | InputScript.input == "Down"))
        {
            input = InputScript.input;
            MeterScript.trigger = 2;
        }
        if (z > 40f)
        {
            input = "null";
            Destroy(gameObject);
        }
    }
}