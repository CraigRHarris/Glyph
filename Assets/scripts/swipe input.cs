using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapeddirectiondetection : MonoBehaviour
{
    public string shapeName; // name the shape 

    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    private bool isSwipeDetected = false;

    // minimum distance for a valid swipe
    private float minSwipeDistance = 50f;

    private Score ScoreScript;
    private SurvivalMeter MeterScript;
    private ObjectSpawner SpawnerScript;
    private Combo ComboScript;
    float speed;
    float z = -10f;

    //Define swipe directions (modify as neeeded)
    public enum SwipeDirection
    {
        Down,
        Up,
        Left,
        Right
    }

    void Start()
    {
        ScoreScript = GameObject.Find("Score").GetComponent<Score>();
        MeterScript = GameObject.Find("Slider").GetComponent<SurvivalMeter>();
        SpawnerScript = GameObject.Find("ObjectSpawner").GetComponent<ObjectSpawner>();
        ComboScript = GameObject.Find("Combo").GetComponent<Combo>();
        speed = SpawnerScript.speed;
    }

    public SwipeDirection requiredSwipeDirection;  //set in the Inspector per shape

    private void OnMouseDown()
    {
        //capture the start position when mouse is pressed down 
        startTouchPosition = Input.mousePosition;
        Debug.Log(startTouchPosition);
    }

    private void OnMouseUp()
    {
        // capute the end position when mouse is released
        
        Debug.Log(endTouchPosition);
        //check if the swipe was dected and validate the direction
        DetectSwipe();
    }

    private void OnMouseDrag()
    {
        endTouchPosition = Input.mousePosition;

    }

    private void DetectSwipe()
    {
        Vector2 swipe = endTouchPosition - startTouchPosition;

        // ckeck if the swipe is long enough to be considered valid
        if (swipe.magnitude >= minSwipeDistance)
        {
            swipe.Normalize(); // normalize the swipe direction

            // Determine the swipe dirction
            
            if (IsSwipeDown(swipe))
            {
                if (requiredSwipeDirection == SwipeDirection.Down)
                {
                    CollectShape();
                }
                
            }
            if (IsSwipeUp(swipe))
            {
                if (requiredSwipeDirection == SwipeDirection.Up)
                {
                    CollectShape();
                }

            }
            if (IsSwipeLeft(swipe))
            {
                if (requiredSwipeDirection == SwipeDirection.Left)
                {
                    CollectShape();
                }
                
            }
            if (IsSwipeRight(swipe))
            {
                if (requiredSwipeDirection == SwipeDirection.Right)
                {
                    CollectShape();
                }
            }
        }
    }

    //methods to check for swipe direction
    private bool IsSwipeUp(Vector2 swipe)
    {
        return swipe.y > 0 && Mathf.Abs(swipe.y) > Mathf.Abs(swipe.x);
    }

    private bool IsSwipeDown(Vector2 swipe)
    {
        return swipe.y < 0 && Mathf.Abs(swipe.y) > Mathf.Abs(swipe.x);
    }

    private bool IsSwipeLeft(Vector2 swipe)
    {
        return swipe.x < 0 && Mathf.Abs(swipe.x) > Mathf.Abs(swipe.y);
    }

    private bool IsSwipeRight(Vector2 swipe)
    {
        return swipe.x > 0 && Mathf.Abs(swipe.x) > Mathf.Abs(swipe.y);
    }

    // call this method when the shape is collectec via correct swipe
    private void CollectShape()
    {
        Debug.Log($"Shape {shapeName} collectecd with a {requiredSwipeDirection} swipe!");

        MeterScript.trigger = 1;
        ComboScript.trigger = 1;

        //Destroy the shape object to simulate it being collected
        Destroy(gameObject);
    } 

    // Update is called once per frame
    void Update()
    {
        z += speed * Time.deltaTime;
        transform.position = new Vector3(0, 1, z);
        if (z > 40f)
        {
            ComboScript.trigger = 2;
            Destroy(gameObject);
        }
    }
}
