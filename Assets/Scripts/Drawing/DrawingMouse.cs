using System;
using System.IO;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class DrawingMouse : MonoBehaviour
{
    public GameObject drawPrefabBig;
    public GameObject drawPrefabSmall;

    GameObject theTrail;
    Plane planeObject;
    Vector3 startPos;

    bool bigBrush;
    bool bigEraser;
    Color currentColor;
    int currLayer = 0;


    void Start()
    {
        planeObject = new Plane(Camera.main.transform.forward * -1, this.transform.position);
    }

    void Update()
    {


       
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == UnityEngine.TouchPhase.Began || Input.GetMouseButtonDown(0))
        {

            //Makes big brush or small brush
            if(currentColor != Color.white)
            {
                if (bigBrush)
                {
                    theTrail = (GameObject)Instantiate(drawPrefabBig, this.transform.position, Quaternion.identity);
                }
                else
                {
                    theTrail = (GameObject)Instantiate(drawPrefabSmall, this.transform.position, Quaternion.identity);
                }

            }
            

            else
            {
                if (bigEraser)
                {
                    theTrail = (GameObject)Instantiate(drawPrefabBig, this.transform.position, Quaternion.identity);
                }
                else
                {
                    theTrail = (GameObject)Instantiate(drawPrefabSmall, this.transform.position, Quaternion.identity);
                }

            }
            //Set brush to current color
            theTrail.GetComponent<TrailRenderer>().startColor = currentColor;
            theTrail.GetComponent<TrailRenderer>().endColor = currentColor;

            theTrail.GetComponent<TrailRenderer>().sortingOrder = currLayer;
            currLayer++;


            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float _dis;
            if (planeObject.Raycast(mouseRay, out _dis))
            {
                startPos = mouseRay.GetPoint(_dis);
            }

        }

        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == UnityEngine.TouchPhase.Moved || Input.GetMouseButton(0))
        {
            
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float _dis;
            if (planeObject.Raycast(mouseRay, out _dis))
            {
                theTrail.transform.position = mouseRay.GetPoint(_dis);
            }
        }

        



    }

    public void setBrushSize(bool bB)
    {
        bigBrush = bB;
        Debug.Log("BigBrush is " + bigBrush);
    }

    public void setEraserSize(bool bE)
    {
        bigEraser = bE;
        Debug.Log("BigEraser is " + bigEraser);
    }

    public void setBrushColor(string color)
    {
        if (color == "Red")
            { currentColor = Color.red; }
        else if (color == "Orange")
            { currentColor = new Color32(255, 87, 0, 255); }
        else if (color == "Yellow")
            { currentColor = Color.yellow; }
        else if (color == "Green")
            { currentColor = Color.green; }
        else if (color == "Blue")
            { currentColor = Color.blue; }
        else if (color == "Purple")
            { currentColor = new Color32(154, 0, 255, 255); }
        else if (color == "Pink")
            { currentColor = new Color32(255, 47, 223, 255); }
        else if (color == "Black")
            { currentColor = Color.black; }
        else if (color == "White")
        { currentColor = Color.white; }
    }
}
