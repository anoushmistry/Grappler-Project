using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject youWinScreen;
    public GameObject youLoseScreen;
    public GameObject UIImage;
    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ReplayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevelButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void YouWin()
    {
        youWinScreen.SetActive(true);
        
    }
    public void YouLose()
    {
        youLoseScreen.SetActive(true);
        UIImage.SetActive(true);

    }


}
