using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManger : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject howToPlay;

    private bool mainMenuActive = true;
    private bool howToPlayActive;

    private void Start()
    {
        //start with the mainmenu active
        mainMenu.SetActive(mainMenuActive);
        howToPlay.SetActive(howToPlayActive);
    }

    ///load the start scene atm1
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    ///activate the how to play menu when the button is pressed
    public void HowToPlay()
    {
        mainMenuActive = false;
        howToPlayActive = true;
        ChangeScreen();
    }

    /// go back to the main menu screen if the button is pressed
    public void BackToMainMenu()
    {
        mainMenuActive = true;
        howToPlayActive = false;
        ChangeScreen();
    }

    ///change the screens
    private void ChangeScreen()
    {
        mainMenu.SetActive(mainMenuActive);
        howToPlay.SetActive(howToPlayActive);
    }

    /// exit the game after the button is pressed
    public void ExitGame()
    {
        Application.Quit();
    }

    private void OnApplicationQuit()
    {
        //here you can sat a save for json if needed
    }
}
