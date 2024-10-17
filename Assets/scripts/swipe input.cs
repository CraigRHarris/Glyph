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

    //Define swipe directions (modify as neeeded)
    public enum SwipeDirection
    {
        Up,
        Down,
        Left,
        Right
    }

    public SwipeDirection requiredSwipeDirection;  //set in the Inspector per shape

    private void OnMouseDown()
    {
        //capture the start position when mouse is pressed down 
        startTouchPosition = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        // capute the end position when mouse is released
        endTouchPosition = Input.mousePosition;

        //check if the swipe was dected and validate the direction
        DetectSwipe();
    }

    private void DetectSwipe()
    {
        Vector2 swipe = endTouchPosition - startTouchPosition;

        // ckeck if the swipe is long enough to be considered valid
        if (swipe.magnitude >= minSwipeDistance)
        {
            swipe.Normalize(); // normalize the swipe direction

            // Determine the swipe dirction
            if (IsSwipeUp(swipe) && requiredSwipeDirection == SwipeDirection.Up)
            {
                CollectShape();
            }
            else if (IsSwipeDown(swipe) && requiredSwipeDirection == SwipeDirection.Down)
            {
                CollectShape();
            }
            else if (IsSwipeLeft(swipe) && requiredSwipeDirection == SwipeDirection.Left)
            {
                CollectShape();
            }
            else if (IsSwipeRight(swipe) && requiredSwipeDirection == SwipeDirection.Right)
            {
                CollectShape();
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
        return swipe.y > 0 && Mathf.Abs(swipe.y) > Mathf.Abs(swipe.x);
    }

    private bool IsSwipeLeft(Vector2 swipe)
    {
        return swipe.y > 0 && Mathf.Abs(swipe.y) > Mathf.Abs(swipe.x);
    }

    private bool IsSwipeRight(Vector2 swipe)
    {
        return swipe.y > 0 && Mathf.Abs(swipe.y) > Mathf.Abs(swipe.x);
    }

    // call this method when the shape is collectec via correct swipe
    private void CollectShape()
    {
        Debug.Log($"Shape {shapeName} collectecd with a {requiredSwipeDirection} swipe!");

        //Destroy the shape object to simulate it being collected
        Destroy(gameObject);
    } 






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
