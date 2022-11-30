using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndScreen : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject endScreenCanvas;

    const string MAIN_MENU = "MainMenu";

    public void DisplayEndScreen()
    {
        endScreenCanvas.SetActive(true);
    }

    public void HideEndScreen()
    {
        StartCoroutine(HideEndScreenCoroutine());
    }

    IEnumerator HideEndScreenCoroutine()
    {
        animator.SetTrigger("Display");
        yield return new WaitForSeconds(1f);
        endScreenCanvas.SetActive(false);
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
