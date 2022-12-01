using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void PlayAgain(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Credits(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
