using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OmnidirectionalObject : MonoBehaviour
{
    public GameObject Score;
    private Score ScoreScript;
    public GameObject Canvas;
    private MouseInput InputScript;
    float z = -10f;
    int hits = 0;
    string input;

    void Start()
    {
        ScoreScript = Score.GetComponent<Score>();
        InputScript = Canvas.GetComponent<MouseInput>();
    }

    void Update()
    {

        z += 20 * Time.deltaTime;
        transform.position = new Vector3(0, 1, z);
        if (InputScript.input != input & (InputScript.input == "Right" | InputScript.input == "Left" | InputScript.input == "Up" | InputScript.input == "Down"))
        {
            input = InputScript.input;
            ScoreScript.trigger = 1;
            hits += 1;
            if (hits == 5)
            {
                ScoreScript.trigger = 2;
                Destroy(gameObject);
                //Get glyph
            }
        }
        if (z > 40f)
        {
            Destroy(gameObject);
        }
    }
}