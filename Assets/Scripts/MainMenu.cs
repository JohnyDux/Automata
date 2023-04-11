using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Canvas;
    public bool IsPaused;

    public bool IsMenu;
    private void Start()
    {
        if (IsMenu)
        {
            PauseGame();
        }
        if (!IsMenu)
        {
            ResumeGame();
        }
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (IsPaused)
            {
                ResumeGame();
            }
            if (!IsPaused)
            {
                PauseGame();
            }
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
        IsPaused = false;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
        IsPaused = false;
        Canvas.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0.0f;
        IsPaused = true;
        Canvas.SetActive(true);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
