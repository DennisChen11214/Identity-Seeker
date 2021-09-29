using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButtons : MonoBehaviour
{
    private GameManager GM;
    public string color;


    // Start is called before the first frame update
    public void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    //Tells GM to select new color
    public void OnClick()
    {
        GM.setCurrentColor(color);

        //Debug.Log("Button Press in colorButton script");
    }
}
