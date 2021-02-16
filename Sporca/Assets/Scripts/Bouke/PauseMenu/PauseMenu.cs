using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject pauseButton;
    private bool paused;

    private void Start()
    {
        pauseScreen.SetActive(false);
    }
    /// <summary>
    /// unpauze and pauze the game
    /// </summary>
    public void PauseGame()
    {
        paused = !paused;

        pauseButton.SetActive(!paused);
        pauseScreen.SetActive(paused);
    }
    /// <summary>
    /// go back to the scene named "MainMenu"
    /// </summary>
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
