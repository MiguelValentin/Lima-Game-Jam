using UnityEngine;

public class ZoomOut : Events
{   

    void OnMouseDown()
    {
        Rooms.Instance.ZoomOut();
        _box.enabled = false;
    }
}