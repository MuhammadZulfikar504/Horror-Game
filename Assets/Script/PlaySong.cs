using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySong : MonoBehaviour
{
    public AudioSource songPlayer;

    public void playThisSoundEffect()
    {
        songPlayer.Play();
    }
}
