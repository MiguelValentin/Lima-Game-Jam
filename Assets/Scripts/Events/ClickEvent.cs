using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    void OnMouseDown()
    {
        Rooms.Instance.Event();
        Destroy(gameObject);
    }
}
