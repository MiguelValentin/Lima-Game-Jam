using System.Collections.Generic;
using UnityEngine;

public class Rooms : Singleton<Rooms>
{

    [SerializeField]
    private GameObject _currentCamera;

    private List<Events> _events = new List<Events>();

    public void AddEvent(Events _event)
    {
        _events.Add(_event);
    }

    public void ZoomIn(GameObject _camera)
    {   
        _currentCamera.SetActive(false);
        _currentCamera = _camera;
        _currentCamera.SetActive(true);
    }

    public void ZoomOut()
    {
        _currentCamera.SetActive(false);
    }

}