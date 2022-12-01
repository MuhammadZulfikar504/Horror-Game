using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGame : MonoBehaviour
{
    void Start()
    {
        BackgroundSong.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
}
