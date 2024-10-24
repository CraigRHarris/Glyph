using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHider : MonoBehaviour
{
    public GameObject Canvas;
    public float IntroLength = 4f;

    private float SceneStartTime;
    // Start is called before the first frame update
    private void Start()
    {
        Canvas.SetActive(false);
        SceneStartTime = Time.time;
    }

    private void Update()
    {
        if (Time.time >= SceneStartTime + IntroLength)
        {
            Canvas.SetActive(true);
        }
    }


    private IEnumerator delay()
    {
        yield return new WaitForSeconds(IntroLength);

    }
}
