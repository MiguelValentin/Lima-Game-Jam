using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Pillow : Items
{
    private Animator _anim;

    protected override void Awake()
    {
        base.Awake();
        _anim = GetComponent<Animator>();
    }


    public override void OnMouseDown()
    {
        base.OnMouseDown();
        _anim.SetBool("Start", true);
        poly.enabled = false;
    }
}