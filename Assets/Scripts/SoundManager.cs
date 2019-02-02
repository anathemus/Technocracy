using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioClip failAudioClip;
    AudioSource fail;

    private void Awake()
    {
        fail = AddAudio(failAudioClip);
    }

    AudioSource AddAudio(AudioClip audioClip)
    {
        AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = audioClip;
        return audioSource;
    }

    public void PlayFail()
    {
        fail.Play();
    }
}
