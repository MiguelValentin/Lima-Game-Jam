using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public abstract class Events : MonoBehaviour
{
     [SerializeField]
    protected GameObject virtualCamera;

    protected BoxCollider2D _box;

    private void Awake()
    {
        _box = GetComponent<BoxCollider2D>();
    }
}
