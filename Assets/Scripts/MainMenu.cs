using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayPlatformer1Player()
    {
        SceneManager.LoadScene("Platformer");
        PlayerPrefs.SetInt("Multiplayer", 0);
    }

    public void PlayPlatformer2Player()
    {
        SceneManager.LoadScene("Platformer");
        PlayerPrefs.SetInt("Multiplayer", 1);
    }

    public void PlayDrawing1Player()
    {
        StaticVar.multiP = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void PlayDrawing2Player()
    {
        StaticVar.multiP = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void PlayMaze()
    {
        SceneManager.LoadScene("Maze");
    }

    public void ExitGame(){
        Application.Quit();
    }
    
}
