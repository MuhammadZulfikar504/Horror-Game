using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void Back(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Close()
    {
        SceneManager.LoadScene(0);
        BackgroundSong.Instance.gameObject.GetComponent<AudioSource>().Play();
    }
}
