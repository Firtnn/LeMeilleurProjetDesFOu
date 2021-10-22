using System;
using UnityEngine.Audio;
using UnityEngine;
using Random = UnityEngine.Random;

public class AudioManager : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void Switch()
    {
        source.clip = clip;
        source.Play();
    }
}
