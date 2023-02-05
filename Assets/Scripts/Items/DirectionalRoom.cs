using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DirectionalRoom : Items
{
    [SerializeField]
    private int room;

    private AudioSource _audio;

    [SerializeField]
    private AudioClip SoundTransition;

    protected override void Awake()
    {
        base.Awake();
        _audio = GetComponent<AudioSource>();
    }

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        _audio.clip = SoundTransition;
        _audio.Play();

        GameManager.Instance.ChangeRoom(room);
    }


}
