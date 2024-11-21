using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        //scene manger moves to the next scene 
        SceneManager.LoadScene("Main Level");
    }
    public void Exit()
    {
        //Exits the game
        Application.Quit();
        Debug.Log("whop");
    }


}
