using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GlyphMove : MonoBehaviour
{
    public GameObject Score;
    private Score ScoreScript;
    float z = -10f;

    void Start()
    {
        ScoreScript = Score.GetComponent<Score>();
    }

    void Update()
    {
        z += 20 * Time.deltaTime;
        transform.position = new Vector3(0, 1, z);
        if (z > 40f)
        {
            Destroy(gameObject);
            //Temporary until input is working
            ScoreScript.trigger = 1;
        }
    }
}
