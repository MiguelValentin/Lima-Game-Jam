using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Fade : Singleton<Fade>
{   


    [SerializeField]
    private Color[] _colors = new Color[2];

    [SerializeField]
    private Image fade;

    [SerializeField]
    private float _speedFade;


    public IEnumerator FadeOut()
    {
        for (int i = 0; i <= 255;)
        {
            fade.color = Color.Lerp(_colors[0], _colors[1], i/255f);

            i+=5;
            if (_speedFade == 0) _speedFade = 1;

            yield return new WaitForSeconds(1/_speedFade);
        }

    }

    public IEnumerator FadeIn()
    {

        for (int i = 255; i >= 0;)
        {
            fade.color = Color.Lerp(_colors[0], _colors[1], i/255f);

            i-=5;
            if (_speedFade == 0) _speedFade = 1;
            yield return new WaitForSeconds(1/_speedFade);
        }
    }



}
