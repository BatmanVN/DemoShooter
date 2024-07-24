using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_TakeDame : MonoBehaviour
{
    [SerializeField] private Health_enemy _health;
    [SerializeField] private Animator zomAnim;
    [SerializeField] private float takeDame;

    private void OnTriggerEnter(Collider enemy)
    {
        if(enemy.CompareTag("AR_bullet"))
        {
            _health.TakeDame(takeDame);
        }
    }
    private void Start()
    {


    }
}
