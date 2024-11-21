using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    //Object References

    public GameObject[] Objects;
    public GameObject[] glyph;

    public GameObject SpawnlocationObject;

    private Combo ComboScript;
    private ValueStore StoreScript;
    private SwipeInput InputScript;
    public float speed = 20f;

    //Time Between Objects
    public float ObjectTimer = 5f;

    float timer;
    int randint;
    public int trigger = 0;

    // Start is called before the first frame update
    void Start()
    {
        ComboScript = GameObject.Find("Combo").GetComponent<Combo>();
        StoreScript = GameObject.Find("ValueStore").GetComponent<ValueStore>();
        //Create first object
        //SpawnObject();
        // Debug.Log(randint);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Object Right(Clone)") == null && GameObject.Find("Object Left(Clone)") == null && GameObject.Find("Object Up(Clone)") == null && GameObject.Find("Object Down(Clone)") == null && GameObject.Find("Object Omnidirectional(Clone)") == null)
        {
            timer += Time.deltaTime;
            //If it's the right time spawn the 
            if (timer > 1f)
            {
                Destroy(GameObject.Find("Glyph1(Clone)"));
                Destroy(GameObject.Find("Glyph2(Clone)"));
                Destroy(GameObject.Find("Glyph3(Clone)"));
                Destroy(GameObject.Find("Glyph4(Clone)"));
                Destroy(GameObject.Find("Glyph5(Clone)"));
                Destroy(GameObject.Find("Glyph6(Clone)"));
                Destroy(GameObject.Find("Glyph7(Clone)"));
                Destroy(GameObject.Find("Glyph8(Clone)"));
                Destroy(GameObject.Find("Glyph9(Clone)"));
                Destroy(GameObject.Find("Glyph10(Clone)"));
                Destroy(GameObject.Find("Glyph11(Clone)"));
                Destroy(GameObject.Find("Glyph12(Clone)"));
                Destroy(GameObject.Find("Glyph13(Clone)"));
                Destroy(GameObject.Find("Glyph14(Clone)"));
                Destroy(GameObject.Find("Glyph15(Clone)"));
                Destroy(GameObject.Find("Glyph16(Clone)"));
                Destroy(GameObject.Find("Glyph17(Clone)"));
                Destroy(GameObject.Find("Glyph18(Clone)"));
                Destroy(GameObject.Find("Glyph19(Clone)"));
                Destroy(GameObject.Find("Glyph20(Clone)"));
                Destroy(GameObject.Find("Glyph21(Clone)"));
                Destroy(GameObject.Find("Glyph22(Clone)"));
                Destroy(GameObject.Find("Glyph23(Clone)"));
                Destroy(GameObject.Find("Glyph24(Clone)"));
                Destroy(GameObject.Find("Glyph25(Clone)"));
                Destroy(GameObject.Find("Glyph26(Clone)"));
                if (ComboScript.combo == 10 | ComboScript.combo == 30 | ComboScript.combo == 50 | ComboScript.combo == 70 | ComboScript.combo == 90)
                {
                    Instantiate(Objects[4], new Vector3(0, 1, -10), Quaternion.identity);
                }
                else
                {
                    randint = UnityEngine.Random.Range(0, Objects.Length - 1);

                    Instantiate(Objects[randint], new Vector3(0, 1, -10), Quaternion.identity);
                }
                speed += 1f;
                timer = 0f;
            }
            if (trigger == 1)
            {

                if (UnityEngine.Random.Range(0, 2) == 1)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (StoreScript.glyphState[i] == 0)
                        {
                            StoreScript.glyphState[i] = 1;
                            Instantiate(glyph[i], new Vector3(0, 1, 0), Quaternion.identity);
                            i = 26;
                        }
                    }
                }
                timer = 0;
                trigger = 0;
            }
        }
    }
}