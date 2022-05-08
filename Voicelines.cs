using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Voicelines : MonoBehaviour
{
    public AudioSource wrongSound;
    public AudioClip[] wrongAudioSources;
    public AudioSource rightSound;
    public AudioClip[] rightAudioSources;
    public UnityEvent onWrongCollision;
    public UnityEvent onRightCollision;



    public void WrongCollision()
    {
        //wrongSound.pitch = 1;
        //wrongSound.Play();
        wrongSound.clip = wrongAudioSources[Random.Range(0, wrongAudioSources.Length)];
        wrongSound.Play();
    }

    public void RightCollision()
    {
        rightSound.pitch = 1;
        rightSound.Play();
    }

//public void WrongCollision()
//{
//    wrongSound.pitch = 1;
//    wrongSound.Play();
//}

//public void RightCollision
//{
//    rightSound.pitch = 1;
//    rightSound.Play();
//}

}