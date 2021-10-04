using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{

    public string nextSceneName;
    public bool lastLevel;

    private int numofcars = 10;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Other car hit!");
        if(other.CompareTag("Car"))
        {
            Destroy(other);
            //game is finished
            numofcars--;
            if(numofcars == 0)
            {
                Debug.Log("You Win!");

                SceneManager.LoadScene(2);
            }
            
        }
    }
}
