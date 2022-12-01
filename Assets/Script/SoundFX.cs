using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{
    public AudioSource btnSound1;
    public AudioSource btnSound2;

    public void PlayBtnSound1()
    {
        btnSound1.Play();
    }

    public void PlayBtnSound2()
    {
        btnSound2.Play();
    }
}
