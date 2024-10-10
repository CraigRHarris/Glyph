using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    public string input = "null";
    float inputx;
    float inputy;

    public void Update()
    {
        if (Input.GetMouseButton(0))
        {
            inputx += (Input.GetAxis("Mouse X"));
            inputy += (Input.GetAxis("Mouse Y"));
            if (inputx > 20f)
            {
                input = "Right";
            }
            if (inputx < -20f)
            {
                input = "Left";
            }
            if (inputy > 20f)
            {
                input = "Up";
            }
            if (inputy < -20f)
            {
                input = "Down";
            }
        }
        else
        {
            inputx = 0;
            inputy = 0;
            input = "null";
        }
    }
}
