using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformerTimer : MonoBehaviour
{
    float timeElapsed;
    Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        timeElapsed = 0;
        timeText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > 60){
            if(timeElapsed % 60 < 10){
                timeText.text = (int)(timeElapsed / 60) + ":0" + (timeElapsed % 60).ToString("F2");
            }
            else{
                timeText.text = (int)(timeElapsed / 60) + ":" + (timeElapsed % 60).ToString("F2");
            }
        }
        else{
            timeText.text = timeElapsed.ToString("F2");
        }
    }
}
