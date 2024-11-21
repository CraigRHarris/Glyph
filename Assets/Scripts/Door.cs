using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private ValueStore StoreScript;
    public GameObject[] glyph;
    public Vector3[] coordinates;

    private void Start()
    {
        StoreScript = GameObject.Find("ValueStore").GetComponent<ValueStore>();
        for (int i = 0; i < 26; i++)
        {
            if (StoreScript.glyphState[i] == 1)
            {
                Instantiate(glyph[i], coordinates[i], Quaternion.identity);
            }
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}