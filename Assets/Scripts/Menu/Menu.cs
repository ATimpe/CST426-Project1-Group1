using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnCloseButton()
    {
        //destroy this
        Destroy(gameObject);
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnMainMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void OnQuitButton()
    {
        //exits the game
        Application.Quit();
    }

    public void OnNextLevelButton()
    {
        SceneManager.LoadScene(2);
    }
}
