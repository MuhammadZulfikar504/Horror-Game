using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject pauseMenuCanvas;

    const string MAIN_MENU = "MainMenu";

    public void DisplayPauseMenu()
    {
        pauseMenuCanvas.SetActive(true);
    }

    public void HidePauseMenu()
    {
        StartCoroutine(HidePauseCoroutine());
    }

    IEnumerator HidePauseCoroutine()
    {
        animator.SetTrigger("Display");
        yield return new WaitForSeconds(1f);
        pauseMenuCanvas.SetActive(false);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(MAIN_MENU);
    }
}
