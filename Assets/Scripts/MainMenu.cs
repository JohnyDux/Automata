using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject CanvasObject;
    private Canvas Canvas;
    public bool IsPaused;

    public bool IsMenu;
    private void Start()
    {
        Canvas = GetComponent<Canvas>();

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
        if (Input.GetKey(KeyCode.Escape) && IsPaused)
        {
            ResumeGame();
        }

        if (Input.GetKey(KeyCode.Escape) && !IsPaused)
        {
            PauseGame();
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
        CanvasObject.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0.0f;
        IsPaused = true;
        CanvasObject.SetActive(true);
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
