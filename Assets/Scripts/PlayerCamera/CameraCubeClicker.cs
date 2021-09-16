using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCubeClicker : MonoBehaviour
{
    
    public GameObject menu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            Instantiate(menu, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
