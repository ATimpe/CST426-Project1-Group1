using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameApplication : MonoBehaviour
{
    // GameApplication acts as the main object that handles the VMC.
    // Code used from https://www.toptal.com/unity-unity3d/unity-with-mvc-how-to-level-up-your-game-development
    public GameModel model;
    public GameView view;
    public GameController controller;

    // Use start to initilize the VMC
    void Start()
    {
        
    }
}
