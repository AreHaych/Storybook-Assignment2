using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOver : MonoBehaviour
{
    public AudioSource voice;

    public void playVoice() {
    	voice.Play(); 
    }
}
