﻿using UnityEngine;
using UnityEngine.EventSystems;

public class CubePlacer : MonoBehaviour
{
    private Grid grid;

    public GameObject myPrefab;

    //add an Event System from under UI
    public EventSystem myEventSystem;

    private void Awake()
    {
        grid = FindObjectOfType<Grid>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject())
            {
                //Do nothing as we clicked on UI
            }
            else
            {
                RaycastHit hitInfo;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hitInfo))
                {
                    PlaceCubeNear(hitInfo.point);
                }
            }
        }


    }

    private void PlaceCubeNear(Vector3 clickPoint)
    {
        var finalPosition = grid.GetNearestPointOnGrid(clickPoint);
        //GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = finalPosition;
        GameObject newCube = Instantiate(myPrefab, transform.position = finalPosition, Quaternion.identity);
        //GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = nearPoint;
        
        // Takes the current type of piece the game currently has you placing 
        // and makes the object placed the same
        newCube.GetComponent<CubeApplication>().model.roadType = GameObject.Find("GameApplication")
                                                                    .GetComponent<GameApplication>()
                                                                    .model
                                                                    .currentPiece;
    }
}