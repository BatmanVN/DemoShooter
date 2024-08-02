using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private Image healthPointValue;

    private void Start()
    {
        health.onHealthChanged.AddListener(UpdateHP);
    }

    public void UpdateHP(float healthPoint, float maxHealPoint)
    {
        healthPointValue.fillAmount = healthPoint / maxHealPoint;
    }
}