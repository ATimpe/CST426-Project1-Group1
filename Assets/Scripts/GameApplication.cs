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

public class GameApplication : MonoBehaviour
{
    // GameApplication acts as the main object that handles the VMC.
    // Code used from https://www.toptal.com/unity-unity3d/unity-with-mvc-how-to-level-up-your-game-development
    public GameModel model;
    public GameView view;
    public GameController controller;
    public GameObject goldUI;

    // Use start to initilize the VMC
    void Start()
    {
        // Makes sure that there is only one GameApplication at a time
        // If one already exists this one destrots itself
        if (FindObjectsOfType<GameApplication>().Length > 1)
            Destroy(gameObject);

        model = gameObject.AddComponent<GameModel>();
        controller = gameObject.AddComponent<GameController>();
        view = gameObject.AddComponent<GameView>();

        // Grabs the goldUI prefab and then Instantiates it
        // model.goldUI = (GameObject)Resources.Load("prefabs/GoldUI", typeof(GameObject));
        model.goldUI = Instantiate(goldUI, new Vector3(0, 0, 0), Quaternion.identity);
        model.piece_price = 10;
        model.gold = 1000;
    }

    public string getCurrentPiece() {
        return model.currentPiece;
    }
}