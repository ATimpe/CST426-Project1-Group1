using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class TimeUIScript : MonoBehaviour
{
    public int startTime = 300;

    private float timer = 0.0f;

    void Update()
    {
        timer += Time.deltaTime;
        int time = startTime - Mathf.RoundToInt(timer);
        gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Time Left: " + time.ToString();

        if (time <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
