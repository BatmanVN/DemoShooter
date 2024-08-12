using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHP;
    [SerializeField] private float _healthPoint;
    public Animator anim;
    public UnityEvent onDie;
    public UnityEvent<float, float> onHealthChanged;
    public UnityEvent onTakeDame;

    public bool Dead => _healthPoint <= 0;


    public float HealthPoint
    { 
        get => _healthPoint; 
        set
        {
            _healthPoint = value;
            onHealthChanged?.Invoke(_healthPoint, maxHP);
        }
    }

    private void Start()
    {
        HealthPoint = maxHP;
    }
    public void TakeDame(float dame)
    {
        if(Dead) return;

        HealthPoint -= dame;
        onTakeDame?.Invoke();
        if(Dead)
        {
            Die();
        }
    }
    protected virtual void Die()
    {
        onDie.Invoke();
    }
}
