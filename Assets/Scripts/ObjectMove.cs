using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public GameObject Score;
    private Score ScoreScript;
    public GameObject Canvas;
    private MouseInput InputScript;
    public string direction;
    float z = -10f;

    void Start()
    {
        ScoreScript = Score.GetComponent<Score>();
        InputScript = Canvas.GetComponent<MouseInput>();
    }

    void Update()
    {

        z += 20 * Time.deltaTime;
        transform.position = new Vector3(0, 1, z);
        if (direction == InputScript.input)
        {
            ScoreScript.trigger = 1;
            Destroy(gameObject);
        }
        if (z > 40f)
        {
            Destroy(gameObject);
        }
    }
}
