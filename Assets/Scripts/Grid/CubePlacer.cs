using UnityEngine;
using UnityEngine.EventSystems;

public class CubePlacer : MonoBehaviour
{
    private Grid grid;
    public GameObject myPrefab;
    public GameObject roadList;

    //add an Event System from under UI
    public EventSystem myEventSystem;

    private void Awake()
    {
        grid = FindObjectOfType<Grid>();
        roadList = GameObject.Find("Roads");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clickedobj = GameObject.FindWithTag("ClickedObject");
            if (EventSystem.current.IsPointerOverGameObject())
            {
                //Do nothing as we clicked on UI
            }
            else if (clickedobj != null)
            {
                //Do nothing as an object has been clicked on and no more should be made.
            }
            else
            {
                RaycastHit hitInfo;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hitInfo))
                {
                    FindObjectOfType<GameApplication>().GetComponent<GameApplication>().controller.app.controller.buyPiece();
                    PlaceCubeNear(hitInfo.point);
                }
            }
        }
    }

    private void PlaceCubeNear(Vector3 clickPoint)
    {
        GameObject newRoad;
        GameObject previousRoad = null;
        Waypoint previousWaypoint = null;
        Waypoint currentWaypoint;

        // only define behavior for previous waypoint if there's at least 1 road placed
        if (roadList.transform.childCount > 0)
        {
            previousRoad = roadList.transform.GetChild(roadList.transform.childCount - 1).gameObject;
            previousWaypoint = previousRoad.GetComponent<Waypoint>();
        }
        
        // road gets placed at grid point closest to clicked point
        var finalPosition = grid.GetNearestPointOnGrid(clickPoint);

        //GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = finalPosition;
        //GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = nearPoint;

        // define properties of the new road below
        newRoad = Instantiate(myPrefab, transform.position = finalPosition, Quaternion.identity, roadList.transform);
        newRoad.name = "Road " + roadList.transform.childCount;
        currentWaypoint = newRoad.GetComponent<Waypoint>();

        // set waypoints below  
        if(previousWaypoint != null)
        {
            currentWaypoint.previousWaypoint = previousWaypoint;
            previousWaypoint.nextWaypoint = currentWaypoint;
        }
    }
}
