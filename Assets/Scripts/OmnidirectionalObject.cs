using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OmnidirectionalObject : MonoBehaviour
{
    private Score ScoreScript;
    private MouseInput InputScript;
    private SurvivalMeter MeterScript;
    private Spawner SpawnerScript;
    float speed;
    float z = -10f;
    int hits = 0;
    int maxhits;
    string input;

    void Start()
    {
        ScoreScript = GameObject.Find("Score").GetComponent<Score>();
        InputScript = GameObject.Find("Canvas").GetComponent<MouseInput>();
        MeterScript = GameObject.Find("Slider").GetComponent<SurvivalMeter>();
        SpawnerScript = GameObject.Find("Spawner").GetComponent<Spawner>();
        speed = SpawnerScript.speed;
        maxhits = Random.Range(5, 10);
    }

    void Update()
    {
        z += speed * Time.deltaTime;
        transform.position = new Vector3(0, 1, z);
        if (InputScript.input != input & (InputScript.input == "Right" | InputScript.input == "Left" | InputScript.input == "Up" | InputScript.input == "Down"))
        {
            input = InputScript.input;
            ScoreScript.trigger = 1;
            MeterScript.trigger = 1;
            hits += 1;
            if (hits == maxhits)
            {
                ScoreScript.trigger = 2;
                Destroy(gameObject);
            }
        }
        if (z > 140f)
        {
            Destroy(gameObject);
        }
    }
}