using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{   

    public static Fade Instance;

    void Awake(){
        DontDestroyOnLoad(gameObject);
        Instance = this;
    }
    [SerializeField]
    private Color[] _colors = new Color[2];

    [SerializeField]
    private Image fade;

    [SerializeField]
    private float _speedFade;


    public IEnumerator FadeOut()
    {
        for (int i = 0; i <= 255; i++)
        {
            fade.color = Color.Lerp(_colors[0], _colors[1], i/255f);

            if (_speedFade == 0) _speedFade = 1;

            yield return new WaitForSecondsRealtime(1/_speedFade);
        }

    }

    public IEnumerator FadeIn()
    {

        for (int i = 255; i >= 0; i--)
        {
            fade.color = Color.Lerp(_colors[0], _colors[1], i/255f);

            if (_speedFade == 0) _speedFade = 1;

            yield return new WaitForSecondsRealtime(1/_speedFade);
        }
    }



}
