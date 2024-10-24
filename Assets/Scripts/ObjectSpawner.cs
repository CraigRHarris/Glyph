using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    //Object References

    public GameObject[] Objects; 

    public GameObject SpawnlocationObject;

    private Combo ComboScript;
    public float speed = 20f;

    //Time Between Objects
    public float ObjectTimer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        ComboScript = GameObject.Find("Combo").GetComponent<Combo>();
        //Create first object
        //SpawnObject();
        // Debug.Log(randint);
    }

    // Update is called once per frame
    void Update()
    {
        //If it's the right time spawn the 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (ComboScript.combo == 10 | ComboScript.combo == 30 | ComboScript.combo == 50 | ComboScript.combo == 70 | ComboScript.combo == 90)
            {
                Instantiate(Objects[4], new Vector3(0, 1, -10), Quaternion.identity);
            }
            else
            {
                SpawnObject();
                speed += 1f;
            }
        }
    }

    public void SpawnObject()
    {
        int randint = Random.Range(1, Objects.Length - 1);

        Instantiate(Objects[randint]);
    }
}
