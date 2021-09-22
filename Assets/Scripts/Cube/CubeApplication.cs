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
    
    // Start is called before the first frame update
    void Start()
    {
        model = gameObject.AddComponent<CubeModel>();
        controller = gameObject.AddComponent<CubeController>();
        view = gameObject.AddComponent<CubeView>();
    }
}
