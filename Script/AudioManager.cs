using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource audio;

    bool m_Play;

    public AudioClip ClickUI;

    void Start()
    {
        audio = GetComponent<AudioSource>();

        audio.Play();
    }

    void PlayClickUI()
    {
        audio.PlayOneShot(ClickUI);
    }
}
