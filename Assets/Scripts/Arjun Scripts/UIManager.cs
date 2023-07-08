using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public GameObject mainMenuScreen;
    public GameObject optionsScreen;
    public GameObject levelScreen;


    public void PlayButton()
    {
        mainMenuScreen.SetActive(false);
        optionsScreen.SetActive(false);
        levelScreen.SetActive(true);
    }
    public void OptionsButton()
    {
        mainMenuScreen.SetActive(false);
        optionsScreen.SetActive(true);
        levelScreen.SetActive(false);

    }
    public void BackButton()
    {
        mainMenuScreen.SetActive(true);
        optionsScreen.SetActive(false);
        levelScreen.SetActive(false);

    }

   
    public void QuitButton()
    {
        Debug.Log("App CLOSED");
        Application.Quit();
    }
}
