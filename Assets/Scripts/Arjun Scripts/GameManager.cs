using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject youWinScreen;
    public GameObject youLoseScreen;
    public GameObject UIImage;

    public static bool GameIsPaused = false;
    public GameObject pauseMenu;
    public GameObject controlsMenu;

    [SerializeField] GameObject InstPanel;
    public TextMeshProUGUI Instruction;
    public int TotalDiamondsToCollect;

    private void Start()
    {
        StartCoroutine(StartInstruction());
    }
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
    public void ControlsMenu()
    {
        controlsMenu.SetActive(true);
        pauseMenu.SetActive(false);

    }
    public void BackButton()
    {
        controlsMenu.SetActive(false);
        pauseMenu.SetActive(true);

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
    IEnumerator StartInstruction()
    {
        InstPanel.SetActive(true);
        Instruction.text = TotalDiamondsToCollect.ToString();
        yield return new WaitForSeconds(3f);
        InstPanel.SetActive(false);



    }


}
