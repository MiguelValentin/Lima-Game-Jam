using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{

    private bool _isBussy = false;

    public void ChangeRoom(int _room)
    {
        if (_isBussy == false)
        {
            _isBussy = true;
            StartCoroutine(LoadRoom(_room));
        }
    }

    private IEnumerator LoadRoom(int _room)
    {
        AsyncOperation scene = SceneManager.LoadSceneAsync("Room" + _room);
        scene.allowSceneActivation = false;
        yield return Fade.Instance.FadeOut();
        scene.allowSceneActivation = true;
        yield return Fade.Instance.FadeIn();
        _isBussy=false;
    }


}
