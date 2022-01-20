using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource _audioSource;
    public AudioClip[] clips;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void BefriendSound()
    {
        int randomClip = Random.Range(0, clips.Length);

        _audioSource.clip = clips[randomClip];
        _audioSource.PlayOneShot(_audioSource.clip, 0.25f);
    }
}
