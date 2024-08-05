using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    public string nameScene;
    public Image loaDing;
    public float time;
    private float alpha;
    private void Start()
    {
        alpha = 0.1f;
        InvokeRepeating(nameof(LoadScene), time, time);
    }


    private void Update()
    {

    }
    public void LoadScene()
    {
        SetAlpha();
        if (alpha < 1f)
        {
            alpha += 0.1f;
            loaDing.fillAmount = alpha / 1f;
        }
        else if (alpha >= 1f)
        {
            SceneManager.LoadScene(nameScene);
        }
    }
    private void SetAlpha()
    {
        Color load = loaDing.color;
        load.a = alpha;
        loaDing.color = load;
    }
}
