using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ValueStore : MonoBehaviour
{
    public static ValueStore Instance;
    public int score;
    public int[] glyphState;
    int newGlyph;

    void Start()
    {
        SceneManager.LoadScene("Main Level");
        glyphState = new int[26];
        for (int i = 0; i < 26; i++)
        {
            glyphState[i] = 0;
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    //Change glyphState from glyph script
}
