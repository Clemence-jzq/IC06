using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Character");
    }

    public void GoToSettingMenu()
    {
        SceneManager.LoadScene("SettingMenu");
    }

    public void GoToCreditMenu()
    {
        SceneManager.LoadScene("CreditMenu");
    }

    public void GotoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("PauseMenu");
        }
    }
}
