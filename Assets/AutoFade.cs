using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoFade : MonoBehaviour
{
    public float visibleDuration;
    public float fadingDuration;
    public CanvasGroup group;

    private float startTime;

    public void Show()
    {
        startTime = Time.time;
        group.alpha = 1f;
        gameObject.SetActive(true);
        Debug.Log("RUN");
    }

    private void TimeCalculate()
    {
        float elascapeTime = Time.time - startTime;
        if (elascapeTime < visibleDuration) return;
        elascapeTime -= visibleDuration;
        if(elascapeTime < fadingDuration)
        {
            group.alpha = 1f - elascapeTime / fadingDuration;
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

    private void OnValidate() => group = GetComponent<CanvasGroup>();
}
