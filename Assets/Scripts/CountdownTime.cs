using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTime : MonoBehaviour
{
    public Text timeText;
    public float countTimeDown;
    private bool isGameStarted = false;
    private int k = 0;
    // Start is called before the first frame update
    void Start()
    { 
        isGameStarted = true;
        Debug.Log("game is starting");
        isGameStarted = true;
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            isGameStarted = !isGameStarted;
            if(isGameStarted) 
            {
                Debug.Log("Start game");
            }
            else 
            {
                Debug.Log("Game over");
            }
        }

        if (isGameStarted)
        {
            if (countTimeDown > k)
            {
                countTimeDown -= Time.deltaTime;
                Timer(countTimeDown);
            }
            else
            {
                Debug.Log("Time out!");
                countTimeDown = 0;
                isGameStarted = false;
            }
        }

    }
    void Timer(float displayTime) 
    {
        displayTime += 1;

        float minutes = Mathf.FloorToInt(displayTime / 60);
        float seconds = Mathf.FloorToInt(displayTime % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

   
}











//referrence(https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/)
