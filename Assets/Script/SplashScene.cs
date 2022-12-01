using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScene : MonoBehaviour
{
    public Animator animSplashScene;

    IEnumerator changeScene(string sceneName)
    {
        animSplashScene.SetTrigger("SplashScreen");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
}
