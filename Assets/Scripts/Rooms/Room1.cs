using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Room1 : Rooms
{
    [SerializeField]
    private AudioClip SoundTransition;

    [SerializeField]
    private int _nextRoom = 0;

    private AudioSource _audio;
    
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }



}

