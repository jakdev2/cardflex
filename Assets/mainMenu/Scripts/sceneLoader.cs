//this script is used to load the practiceAlone scene on play button press

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    //create a function that loads the practiceAlone scene
    public void LoadPlay()
    {
        SceneManager.LoadScene("practiceAlone");
    }

    //create a function that loads the main menu scene
    public void LoadMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }

    //create a function that loads the options scene
    public void LoadOptions()
    {
        SceneManager.LoadScene("options");
    }
    
    //create a function that exits the game
    public void ExitGame()
    {
        Application.Quit();
    }
}
