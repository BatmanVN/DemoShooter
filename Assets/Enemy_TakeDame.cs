using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_TakeDame : MonoBehaviour
{
    [SerializeField] private Health_enemy _health;
    [SerializeField] private Animator zomAnim;
    [SerializeField] private float takeDame;
    [SerializeField] private Collider[] enemy;

    [ContextMenu("ADD Collider")]
    public void ADDCollider()
    {
        enemy = GetComponentsInChildren<Collider>();
    }
    private void OnTriggerEnter()
    {
        for (int i = 0; i < enemy.Length; i++)
        {
            if (enemy[i].CompareTag("AR_bullet"))
            {
                _health.TakeDame(takeDame);
            }
            if (_health.Dead)
            {
                zomAnim.SetTrigger("dead");
            }
        }
    }
    private void Start()
    {


    }
}
