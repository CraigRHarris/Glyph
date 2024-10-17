using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    //private void Awake() { audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>(); } 
    // audioManager.PlaySFX(audioManager.name);
    
    [Header("Audio Clip")]
    public AudioClip example1;

    private void Start()
    {
        musicSource.clip = example1;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
