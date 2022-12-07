using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour {

    public AudioClip wall;
    public AudioClip racket;
    public AudioClip score;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void WallSound()
    {
        audioSource.clip = wall;
        audioSource.Play();
    }

    public void RacketSound()
    {
        audioSource.clip = racket;
        audioSource.Play();
    }

    public void ScoreSound()
    {
        audioSource.clip = score;
        audioSource.Play();
    }
}
