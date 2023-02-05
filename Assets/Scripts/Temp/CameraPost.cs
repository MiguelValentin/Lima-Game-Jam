using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine.PostFX;
using UnityEngine.Rendering.PostProcessing;

public class CameraPost : Singleton<CameraPost>
{

    private int _drunk = 0;

    private void Start()
    {
        PostDrunk();
    }

    public void PostDrunk()
    {
        if (_drunk < 3)
        {
            _drunk++;
            GetComponent<Animator>().SetTrigger("Drunk" + _drunk);
        }
    }

    public void PostNonDrunk()
    {
        if (_drunk >= 1)
        {
            _drunk--;
            GetComponent<Animator>().SetTrigger("Drunk" + _drunk);

        }
    }
}
