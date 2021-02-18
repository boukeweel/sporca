using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    private AudioSource click;

    void Start()
    {
        click = GetComponent<AudioSource>();    
    }
    /// <summary>
    /// retry the game it loads scene number 1 in atm
    /// </summary>
    public void Retry()
    {
        click.Play();
        SceneManager.LoadScene(1);
    }
    /// <summary>
    /// back to main menu it load the scne with the name "MainMenu"
    /// </summary>
    public void BackToMainMenu()
    {
        click.Play();
        SceneManager.LoadScene("MainMenu");
    }
    /// <summary>
    /// exit the game
    /// </summary>
    public void ExitGame()
    {
        click.Play();
        Application.Quit();
    }
}
