using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Object : MonoBehaviour
{
    public GameObject Score;
    private Score ScoreScript;
    public GameObject Canvas;
    private MouseInput InputScript;
    public GameObject Slider;
    private SurvivalMeter MeterScript;
    public string direction;
    float z = -10f;
    string input;

    void Start()
    {
        //ScoreScript = Score.GetComponent<Score>();
        //InputScript = Canvas.GetComponent<MouseInput>();
        //MeterScript = Slider.GetComponent<SurvivalMeter>();
    }

    void Update()
    {

        z += 20 * Time.deltaTime;
        transform.position = new Vector3(0, 1, z);
        //if (InputScript.input == direction)
        //{
        //    input = "null";
        //    ScoreScript.trigger = 1;
        //    MeterScript.trigger = 1;
        //    Destroy(gameObject);
        //}
        //if (InputScript.input != direction & InputScript.input != input &(InputScript.input == "Right" | InputScript.input == "Left" | InputScript.input == "Up" | InputScript.input == "Down"))
        //{
        //    input = InputScript.input;
        //    MeterScript.trigger = 2;
        //}
        //if (z > 40f)
        //{
        //    input = "null";
        //    Destroy(gameObject);
        //}
    }
}