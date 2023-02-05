using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Portrait : Items
{
    [SerializeField]
    private AudioSource _audio;


    public override void OnMouseDown()
    {
        base.OnMouseDown();
        _audio.Play();
        CameraPost.Instance.PostNonDrunk();
        
    }
}
