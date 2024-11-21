using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctionality : MonoBehaviour
{
    public void RestartCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToAncientDoor()
    {
        SceneManager.LoadScene("Ancient Door");
    }
}
