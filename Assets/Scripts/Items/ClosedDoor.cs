using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosedDoor : Items
{   
    private AudioSource _audio;

    protected override void Awake()
    {
        base.Awake();
        _audio = GetComponent<AudioSource>();
    }

    public override void OnMouseDown()
    {
        _audio.Play();
         
    }
}
