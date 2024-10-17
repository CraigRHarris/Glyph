using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    //Object References
    public GameObject Right;
    public GameObject Left;
    public GameObject Up; 
    public GameObject Down;

    public GameObject SpawnlocationObject;

    //Time Between Objects
    public float ObjectTimer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //Create first object
        int randint = Random.Range(1, 4);
        // Debug.Log(randint);
        if(randint == 1)
        {
            Instantiate(Right, SpawnlocationObject.transform);
        }
        if(randint == 2)
        {
            Instantiate(Left, SpawnlocationObject.transform);
        }
        if (randint == 3)
        {
            Instantiate(Up, SpawnlocationObject.transform);
        }
        if (randint == 4)
        {
            Instantiate(Down, SpawnlocationObject.transform);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //If it's the right time spawn the 
    }
}
