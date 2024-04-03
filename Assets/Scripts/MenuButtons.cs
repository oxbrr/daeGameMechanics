using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public void OnStartGameButtonClicked()
    {
        Debug.Log("Game Start");
    }

    private bool isPaused = false;

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
        if (Time.timeScale == 1)
        {
            Debug.Log("Unpaused");
        }
        else
        {
            Debug.Log("Pause");
        }
    }

    public void MainMenuButtonClicked()
    {
        Debug.Log("Sent to Main Menu");
        SceneManager.LoadScene("MainMenu");
    }

    public void DebugMenuButtonClicked()
    {
        Debug.Log("Sent to Debug Room");
        SceneManager.LoadScene("Debug Room");
    }

    public void DEBUGRetryButtonClicked()
    {
        Debug.Log("Retried Debug Room");
        SceneManager.LoadScene("Debug Room");
    }
}
