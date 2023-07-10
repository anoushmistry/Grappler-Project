using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject youWinScreen;
    public GameObject youLoseScreen;
    public GameObject UIImage;

    public static bool GameIsPaused = false;
    public GameObject pauseMenu;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;

    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }

  
    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;

    }
    public void ReplayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
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
