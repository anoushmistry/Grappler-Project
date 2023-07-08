using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelector : MonoBehaviour
{
    public int level;
    public TextMeshProUGUI levelNumber;

    private void Start()
    {
        levelNumber.text = level.ToString();
    }
    public void openScene()
    {
        SceneManager.LoadScene("Level " + level.ToString());
    }
}
