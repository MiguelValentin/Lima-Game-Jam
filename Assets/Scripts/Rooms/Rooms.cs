using UnityEngine;

public class Rooms : Singleton<Rooms>
{

    [SerializeField]
    private GameObject _currentCamera;

    public void ZoomIn(GameObject _camera)
    {
        _currentCamera = _camera;
        _currentCamera.SetActive(true);
    }

    public void ZoomOut()
    {
        _currentCamera.SetActive(false);
    }

}