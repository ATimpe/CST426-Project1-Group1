using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameElement : MonoBehaviour
{
    // Element code acts as a way of catagorizing and giving access to all the seperate VMCs that are under the same catagory. 
    // Game will only have one naturally but other ones may have multiple.
    // Code used from: https://www.toptal.com/unity-unity3d/unity-with-mvc-how-to-level-up-your-game-development

    public GameApplication app { get { return GameObject.FindObjectOfType<GameApplication>(); }}
}