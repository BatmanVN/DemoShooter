using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoFade : MonoBehaviour
{
    public float visibleDuration;
    public float fadingDuration;
    public Image image;

    private float startTime;

    public void Show()
    {
        startTime = Time.time;
        SetAlpha(1f);
        gameObject.SetActive(true);
    }

    private void TimeCalculate()
    {
        float escapeTime = Time.time - startTime;
        if (escapeTime < visibleDuration) return;
        escapeTime -= visibleDuration;
        if(escapeTime < fadingDuration)
        {
            SetAlpha(1f - escapeTime / fadingDuration);
        }
        else
        {
            Hide();
        }
    }
    private void Update()
    {
        TimeCalculate();
    }
    private void Hide() => gameObject.SetActive(false);

    private void OnValidate() => image = GetComponent<Image>();
    private void SetAlpha(float alpha)
    {
        var newColor = image.color;
        newColor.a = alpha;
        image.color = newColor;
    }
}
