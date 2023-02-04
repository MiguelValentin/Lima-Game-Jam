using UnityEngine;

public class ZoomIn : Events
{   
   
    void OnMouseDown()
    {
        Rooms.Instance.ZoomIn(virtualCamera);
        _box.enabled = false;
    }
}