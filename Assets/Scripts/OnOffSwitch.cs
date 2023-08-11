using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffSwitch : MonoBehaviour
{

    public AudioSource audioSource;
    private bool isAudioPlaying = true;


    public void ToggleAudioSource()
    {
        if (audioSource != null)
        {
            audioSource.enabled = !audioSource.enabled; 
        }
    }
}
