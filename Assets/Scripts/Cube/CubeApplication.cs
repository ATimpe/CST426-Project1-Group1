using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeElement : MonoBehaviour
{
    public CubeApplication app { get { return GameObject.FindObjectOfType<CubeApplication>(); }}
}

public class CubeApplication : MonoBehaviour
{
    public CubeModel model;
    public CubeView view;
    public CubeController controller;
<<<<<<< Updated upstream
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
=======
    
    // Start is called before the first frame update
    void Start()
    {
        // Sets the current type of cube the player is placing and writes the value into the model
        //GameModel model_ = FindObjectOfType<GameApplication>().GetComponent<GameApplication>().model;
        //string hello = model_.getCurrentPiece();
    }
}
>>>>>>> Stashed changes
