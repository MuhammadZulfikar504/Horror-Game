using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSong : MonoBehaviour
{
    private static BackgroundSong instance = null;

    public static BackgroundSong Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        } else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
