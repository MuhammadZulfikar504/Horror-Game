using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSong : MonoBehaviour
{
    void Start()
    {
        BackSong.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
}
