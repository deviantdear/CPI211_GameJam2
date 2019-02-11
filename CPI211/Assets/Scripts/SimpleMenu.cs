using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleMenu : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject gameGUI;
    public GameObject endMenu;

    public void startGame()
    {
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadLevel()
    {
       //determine the level the player is on, re-spawn at that level 

    }

    public void Exit()
    {
        Application.Quit();
    }
   
}
