using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1.0f;
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    public void PauseGame()
    {
        //Cursor.visible = true;
        //Cursor.lockState = CursorLockMode.Confined;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Main Menu");
        //Cursor.visible = true;
        //Cursor.lockState = CursorLockMode.Confined;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
