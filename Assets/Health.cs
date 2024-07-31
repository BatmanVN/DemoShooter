using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHP;
    [SerializeField] private float hP;
    public UnityEvent onDie;
    //public float MaxHP { get => maxHP; set => maxHP = value; }
    //public float HP { get => hP; set => hP = value; }

    public bool Dead => hP <= 0;
    private void Start()
    {
        hP = maxHP;
    }
    public void TakeDame(float dame)
    {
        if(Dead) return;
         hP -= dame;
        if(Dead)
        {
            Die();
        }
    }
    private void Die() => onDie.Invoke();
}
