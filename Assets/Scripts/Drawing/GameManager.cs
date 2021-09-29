using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject mpBorder;
    //public bool multiPlayer;
    public GameObject drawManager;
    public GameObject colorGrid;

    public GameObject RedButton;
    public GameObject OrangeButton;
    public GameObject YellowButton;
    public GameObject GreenButton;
    public GameObject BlueButton;
    public GameObject PurpleButton;
    public GameObject PinkButton;
    public GameObject BlackButton;
    public GameObject WhiteButton;

    // Start is called before the first frame update
    void Start()
    {
        List<GameObject> colorList = new List<GameObject>();
        //Add all color buttons to list
        colorList.Add(RedButton);
        colorList.Add(OrangeButton);
        colorList.Add(YellowButton);
        colorList.Add(GreenButton);
        colorList.Add(BlueButton);
        colorList.Add(PurpleButton);
        colorList.Add(PinkButton);
        colorList.Add(BlackButton);

        //Determine whether brush is big or small
        if (Random.value >= 0.5)
        { drawManager.GetComponent<DrawingMouse>().setBrushSize(true); }

        else
        { drawManager.GetComponent<DrawingMouse>().setBrushSize(false); }

        //Determine whether eraser is big or small
        if (Random.value >= 0.5)
        { drawManager.GetComponent<DrawingMouse>().setEraserSize(true); }

        else
        { drawManager.GetComponent<DrawingMouse>().setEraserSize(false); }


        //Figure out how many colors will be avalible
        int numColor = Random.Range(1, 9);
        int index = 0;
        int colorsInList = 8;

        while (colorsInList > numColor)
        {
            index = Random.Range(0, colorsInList);
            colorList.RemoveAt(index);
            colorsInList--;
        }

        Debug.Log("Number of colors is " + numColor);

        placeColors(colorList);

        //Coinflip on whether white(eraser) is added to the color list
        if (Random.value >= 0.5)
        {
            GameObject color = Instantiate(WhiteButton);
            color.transform.SetParent(colorGrid.transform, false);
            Debug.Log("Eraser Color added");
        }

        //Make two canvases
        if (StaticVar.multiP)
        {
            mpBorder.GetComponent<Image>().color = Color.black;
        }
        else 
        {
            mpBorder.active = false;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    void placeColors(List<GameObject> cL)
    {
        foreach (GameObject c in cL)
        {
            GameObject color = Instantiate(c);
            color.transform.SetParent(colorGrid.transform, false);
        }
    }

    public void setCurrentColor(string c)
    {
        //Debug.Log("Button Press in colorButton script");
        drawManager.GetComponent<DrawingMouse>().setBrushColor(c);
        Debug.Log("New Color is " + c);

    }

    public void GoBackMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
