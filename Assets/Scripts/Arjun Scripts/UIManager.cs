using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public GameObject mainMenuScreen;
    public GameObject optionsScreen;
    public GameObject levelScreen;
    public GameObject InstructionScreen;
    public GameObject StoryScreen;
    public GameObject mainBg;
    public GameObject secondBg;


    public void PlayButton()
    {
        mainMenuScreen.SetActive(false);
        optionsScreen.SetActive(false);
        levelScreen.SetActive(false);
        InstructionScreen.SetActive(false);
        StoryScreen.SetActive(true);
        secondBg.SetActive(true);


    }
    public void OptionsButton()
    {
        mainMenuScreen.SetActive(false);
        optionsScreen.SetActive(true);
        levelScreen.SetActive(false);
        InstructionScreen.SetActive(false);
        StoryScreen.SetActive(false);
        mainBg.SetActive(false);
        secondBg.SetActive(true);

    }
    public void InstructionsButton()
    {
        mainMenuScreen.SetActive(false);
        optionsScreen.SetActive(false);
        levelScreen.SetActive(false);
        InstructionScreen.SetActive(true);
        StoryScreen.SetActive(false);
        mainBg.SetActive(false);
        secondBg.SetActive(true);





    }
    public void BackButton()
    {
        mainMenuScreen.SetActive(true);
        optionsScreen.SetActive(false);
        levelScreen.SetActive(false);
        InstructionScreen.SetActive(false);
        StoryScreen.SetActive(false);
        mainBg.SetActive(true);
        secondBg.SetActive(false);





    }
    public void NextButton()
    {
        mainMenuScreen.SetActive(false);
        optionsScreen.SetActive(false);
        levelScreen.SetActive(true);
        InstructionScreen.SetActive(false);
        StoryScreen.SetActive(false);



    }


    public void QuitButton()
    {
        Debug.Log("App CLOSED");
        Application.Quit();
    }
}
