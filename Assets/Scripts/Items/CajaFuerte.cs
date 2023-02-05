using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CajaFuerte : Items
{      

    [SerializeField]
    private AudioSource _audio;

    public GameObject front;



    public override void OnMouseDown()
    {
        base.OnMouseDown();
        _audio.Play();

    }
}
