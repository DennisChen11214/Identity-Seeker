using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeValue = 15f; //Minutes
    private float timeSinceGameStart = 0;
    private Text timerText;
    
    
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();

        timeValue *= 60;
        timeValue -= StaticVar.time;


    }

    // Update is called once per frame
    void Update()
    {
        StaticVar.time += Time.deltaTime;

        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }

        else
        {
            //StaticTime.time = 0;
            timeValue = 0;
        }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
            { timeToDisplay = 0; }

        else if (timeToDisplay > 0)
            { timeToDisplay += 1;}

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
