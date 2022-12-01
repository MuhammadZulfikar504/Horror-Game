using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackSong : MonoBehaviour
{
    private static BackSong instance = null;

    public static BackSong Instance
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
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
