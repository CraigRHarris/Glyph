using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ValueStore : MonoBehaviour
{
    public static ValueStore Instance;
    public int score;

    private void Start()
    {
        SceneManager.LoadScene("Daniel");
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
}
