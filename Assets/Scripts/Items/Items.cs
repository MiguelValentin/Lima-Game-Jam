using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D), typeof(Sprite))]
public class Items : MonoBehaviour
{
    

    [HideInInspector]
    public PolygonCollider2D poly;

    [HideInInspector]
    public Sprite image;

    protected virtual void Awake()
    {
        poly = GetComponent<PolygonCollider2D>();
        image = GetComponent<Sprite>();
    }

    public virtual void OnMouseDown() { }
}
