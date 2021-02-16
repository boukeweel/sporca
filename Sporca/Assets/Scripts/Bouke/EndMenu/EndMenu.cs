using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    /// <summary>
    /// retry the game it loads scene number 1 in atm
    /// </summary>
    public void Retry()
    {
        SceneManager.LoadScene(1);
    }
    /// <summary>
    /// back to main menu it load the scne with the name "MainMenu"
    /// </summary>
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    /// <summary>
    /// exit the game
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }
}
