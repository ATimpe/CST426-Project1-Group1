using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnPlayButton()
    {
        //loads scene on index 1
        SceneManager.LoadScene(1);
    }

    public void OnQuitButton()
    {
        //exits the game
        Application.Quit();
    }
}
