using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectRight;
    public GameObject ObjectLeft;
    public GameObject ObjectUp;
    public GameObject ObjectDown;
    public GameObject OmnidirectionalObject;
    public float speed = 20f;
    float timer;
    int type;
    int direction;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3f)
        {
            type = Random.Range(0, 5);
            if (type == 0)
            {
                Instantiate(ObjectRight, new Vector3(0, 1, -10), Quaternion.identity);
            }
            if (type == 1)
            {
                Instantiate(ObjectLeft, new Vector3(0, 1, -10), Quaternion.identity);
            }
            if (type == 2)
            {
                Instantiate(ObjectUp, new Vector3(0, 1, -10), Quaternion.identity);
            }
            if (type == 3)
            {
                Instantiate(ObjectDown, new Vector3(0, 1, -10), Quaternion.identity);
            }
            if (type == 4)
            {
                Instantiate(OmnidirectionalObject, new Vector3(0, 1, -10), Quaternion.identity);
            }
            speed += 1f;
            timer = 0f;
        }
    }
}