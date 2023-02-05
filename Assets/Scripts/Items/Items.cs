using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D), typeof(Sprite),typeof(Animator))]
public abstract class Items : MonoBehaviour
{

    [HideInInspector]
    public Collider2D poly;

    [HideInInspector]
    public Sprite image;

    protected Animator _anim;
    protected virtual void Awake()
    {
        poly = GetComponent<Collider2D>();
        image = GetComponent<Sprite>();
        _anim = GetComponent<Animator>();

    }

    public virtual void OnMouseDown() {
        _anim.SetBool("Start", true);
        poly.enabled = false;
    
     }
}
