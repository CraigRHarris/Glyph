using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    //Object References

    public GameObject[] Objects; 

    public GameObject SpawnlocationObject;

    //Time Between Objects
    public float ObjectTimer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //Create first object
        SpawnObject();
        // Debug.Log(randint);

    }

    // Update is called once per frame
    void Update()
    {
        //If it's the right time spawn the 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
    }

    public void SpawnObject()
    {
        int randint = Random.Range(1, Objects.Length);

        Instantiate(Objects[randint]);
    }
}
