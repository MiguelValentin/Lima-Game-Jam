using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public abstract class Events : MonoBehaviour
{
     [SerializeField]
    protected GameObject virtualCamera;

    private void Awake()
    {
        Rooms.Instance.AddEvent(this);
    }
}
